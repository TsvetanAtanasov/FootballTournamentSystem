namespace FootballTournamentSystem.Statistics.Infrastructure
{
    using Microsoft.EntityFrameworkCore;
    using Core.Infrastructure.Persistence;
    using FootballTournamentSystem.Statistics.Domain.Models.TournamentStatistics;
    using FootballTournamentSystem.Statistics.Domain.Models.PlayerStatistics;
    using FootballTournamentSystem.Statistics.Domain.Models.MatchStatistics;

    internal interface IStatisticsDbContext : IDbContext
    {
        DbSet<TournamentStatistics> TournamentStatistics { get; }

        DbSet<PlayerStatistics> PlayerStatistics { get; }

        DbSet<MatchStatistics> MatchStatistics { get; }
    }
}
