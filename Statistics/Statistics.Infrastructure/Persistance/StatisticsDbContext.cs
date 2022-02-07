namespace FootballTournamentSystem.Statistics.Infrastructure.Persistance
{
    using System.Reflection;
    using Microsoft.EntityFrameworkCore;
    using FootballTournamentSystem.Statistics.Domain.Models.MatchStatistics;
    using FootballTournamentSystem.Statistics.Domain.Models.PlayerStatistics;
    using FootballTournamentSystem.Statistics.Domain.Models.TournamentStatistics;

    public class StatisticsDbContext : DbContext,
        IStatisticsDbContext
    {
        public StatisticsDbContext(DbContextOptions<StatisticsDbContext> options)
            : base(options)
        {
        }

        public DbSet<TournamentStatistics> TournamentStatistics { get; set; } = default!;

        public DbSet<PlayerStatistics> PlayerStatistics { get; set; } = default!;

        public DbSet<MatchStatistics> MatchStatistics { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}