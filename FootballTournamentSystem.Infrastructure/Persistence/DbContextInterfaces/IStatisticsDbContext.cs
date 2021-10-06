namespace FootballTournamentSystem.Infrastructure.Persistence.DbContextInterfaces
{
    using Domain.Models.Statistics.TournamentStatistics;
    using Domain.Models.Statistics.PlayerStatistics;
    using Domain.Models.Statistics.MatchStatistics;
    using Microsoft.EntityFrameworkCore;
    using Core.Infrastructure.Persistence;

    internal interface IStatisticsDbContext : IDbContext
    {
        DbSet<TournamentStatistics> TournamentStatistics { get; }

        DbSet<PlayerStatistics> PlayerStatistics { get; }

        DbSet<MatchStatistics> MatchStatistics { get; }
    }
}
