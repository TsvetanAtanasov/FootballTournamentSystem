namespace FootballTournamentSystem.Domain.Factories.Statistics.MatchStatistics
{
    using global::Common.Domain;
    using Models.Statistics.MatchStatistics;

    public interface IMatchStatisticsFactory : IFactory<MatchStatistics>
    {
        IMatchStatisticsFactory WithHomeTeamGoals(int homeGoals);

        IMatchStatisticsFactory WithAwayTeamGoals(int awayGoals);
    }
}
