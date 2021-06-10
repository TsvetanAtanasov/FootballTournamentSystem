namespace FootballTournamentSystem.Infrastructure.Persistence
{
    using System.Reflection;
    using Microsoft.EntityFrameworkCore;
    using Domain.Models.TournamentContext.Tournament;
    using Domain.Models.TournamentContext.Match;
    using Domain.Models.TournamentContext.Team;
    using Domain.Models.StatisticsContext.TournamentStatistics;
    using Domain.Models.StatisticsContext.PlayerStatistics;
    using Domain.Models.StatisticsContext.MatchStatistics;
    using Domain.Models.PersonContext.Referee;
    using Domain.Models.PersonContext.President;
    using Domain.Models.PersonContext.Player;
    using Domain.Models.PersonContext.Coach;
    using Infrastructure.Persistence.DbContextInterfaces;

    internal class FootballTournamentDbContext : DbContext,
        ITournamentDbContext,
        IStatisticsDbContext,
        IPersonDbContext
    {
        public FootballTournamentDbContext(DbContextOptions<FootballTournamentDbContext> options)
            : base(options)
        {
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
