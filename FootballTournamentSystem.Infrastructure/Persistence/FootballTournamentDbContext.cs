namespace FootballTournamentSystem.Infrastructure.Persistence
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;
    using Common.Domain.Models;
    using Common.Infrastructure.Events;
    using Domain.Models.Person.Coach;
    using Domain.Models.Person.Player;
    using Domain.Models.Person.President;
    using Domain.Models.Person.Referee;
    using Domain.Models.Statistics.MatchStatistics;
    using Domain.Models.Statistics.PlayerStatistics;
    using Domain.Models.Statistics.TournamentStatistics;
    using Domain.Models.Tournament.Match;
    using Domain.Models.Tournament.Team;
    using Domain.Models.Tournament.Tournament;
    using Infrastructure.Persistence.DbContextInterfaces;
    using Microsoft.EntityFrameworkCore;

    // Return to internal when extracting microservices
    public class FootballTournamentDbContext : DbContext,
        ITournamentDbContext,
        IStatisticsDbContext,
        IPersonDbContext
    {
        private readonly IEventDispatcher eventDispatcher;
        private readonly Stack<object> savesChangesTracker;

        public FootballTournamentDbContext(
            DbContextOptions<FootballTournamentDbContext> options, 
            IEventDispatcher eventDispatcher)
            : base(options)
        {
            this.eventDispatcher = eventDispatcher;

            this.savesChangesTracker = new Stack<object>();
        }

        // Tournament Context
        public DbSet<Tournament> Tournaments { get; set; } = default!;

        public DbSet<SemiFinals> SemiFinals { get; set; } = default!;

        public DbSet<RoundOf16> RoundOf16s { get; set; } = default!;

        public DbSet<QuarterFinals> QuarterFinals { get; set; } = default!;

        public DbSet<Group> Groups { get; set; } = default!;

        public DbSet<Final> Finals { get; set; } = default!;

        public DbSet<Match> Matches { get; set; } = default!;

        public DbSet<Team> Teams { get; set; } = default!;

        // Statistics Context
        public DbSet<TournamentStatistics> TournamentStatistics { get; set; } = default!;

        public DbSet<PlayerStatistics> PlayerStatistics { get; set; } = default!;

        public DbSet<MatchStatistics> MatchStatistics { get; set; } = default!;

        // Person Context
        public DbSet<Referee> Referees { get; set; } = default!;

        public DbSet<President> Presidents { get; set; } = default!;

        public DbSet<Player> Players { get; set; } = default!;

        public DbSet<Coach> Coaches { get; set; } = default!;

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            this.savesChangesTracker.Push(new object());

            var entities = this.ChangeTracker
                .Entries<IEntity>()
                .Select(e => e.Entity)
                .Where(e => e.Events.Any())
                .ToArray();

            foreach (var entity in entities)
            {
                var events = entity.Events.ToArray();

                entity.ClearEvents();

                foreach (var domainEvent in events)
                {
                    await this.eventDispatcher.Dispatch(domainEvent);
                }
            }

            this.savesChangesTracker.Pop();

            if (!this.savesChangesTracker.Any())
            {
                return await base.SaveChangesAsync(cancellationToken);
            }

            return 0;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
