namespace FootballTournamentSystem.Domain.Factories.Statistics.TournamentStatistics
{
    using Models.Statistics.TournamentStatistics;
    using Core.Domain;

    public interface ITournamentStatisticsFactory : IFactory<TournamentStatistics>
    {
        ITournamentStatisticsFactory WithGoalsScored(int goalsScored);
    }
}
