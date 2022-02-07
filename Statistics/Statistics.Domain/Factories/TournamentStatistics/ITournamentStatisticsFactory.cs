namespace FootballTournamentSystem.Statistics.Domain.Factories.TournamentStatistics
{
    using FootballTournamentSystem.Statistics.Domain.Models.TournamentStatistics;
    using Core.Domain;

    public interface ITournamentStatisticsFactory : IFactory<TournamentStatistics>
    {
        ITournamentStatisticsFactory WithGoalsScored(int goalsScored);
    }
}
