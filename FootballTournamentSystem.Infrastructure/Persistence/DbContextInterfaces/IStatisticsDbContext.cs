namespace FootballTournamentSystem.Infrastructure.Persistence.DbContextInterfaces
{
    using Domain.Models.StatisticsContext.TournamentStatistics;
    using Domain.Models.StatisticsContext.PlayerStatistics;
    using Domain.Models.StatisticsContext.MatchStatistics;
    using Microsoft.EntityFrameworkCore;
    using Common.Infrastructure.Persistence;

    internal interface IStatisticsDbContext : IDbContext
    {
        DbSet<TournamentStatistics> TournamentStatistics { get; }

        DbSet<PlayerStatistics> PlayerStatistics { get; }

        DbSet<MatchStatistics> MatchStatistics { get; }
    }
}
