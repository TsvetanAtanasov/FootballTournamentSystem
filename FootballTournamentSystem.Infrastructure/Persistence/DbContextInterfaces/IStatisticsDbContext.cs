namespace FootballTournamentSystem.Infrastructure.Persistence.DbContextInterfaces
{
    using Domain.Models.StatisticsContext.TournamentStatistics;
    using Domain.Models.StatisticsContext.PlayerStatistics;
    using Domain.Models.StatisticsContext.MatchStatistics;
    using Microsoft.EntityFrameworkCore;

    internal interface IStatisticsDbContext
    {
        DbSet<TournamentStatistics> TournamentStatistics { get; }

        DbSet<PlayerStatistics> PlayerStatistics { get; }

        DbSet<MatchStatistics> MatchStatistics { get; }
    }
}
