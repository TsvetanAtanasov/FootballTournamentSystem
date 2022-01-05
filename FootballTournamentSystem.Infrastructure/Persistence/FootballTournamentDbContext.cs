namespace FootballTournamentSystem.Infrastructure.Persistence
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;
    using Core.Domain.Models;
    using Core.Infrastructure.Events;
    using Domain.Models.Person.Coach;
    using Domain.Models.Person.Player;
    using Domain.Models.Person.President;
    using Domain.Models.Person.Referee;
    using Domain.Models.Statistics.MatchStatistics;
    using Domain.Models.Statistics.PlayerStatistics;
    using Domain.Models.Statistics.TournamentStatistics;
    using Infrastructure.Persistence.DbContextInterfaces;
    using Microsoft.EntityFrameworkCore;

    // Return to internal when extracting microservices
    public class FootballTournamentDbContext : DbContext,
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
