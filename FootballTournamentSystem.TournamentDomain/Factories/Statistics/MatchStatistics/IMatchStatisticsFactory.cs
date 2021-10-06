namespace FootballTournamentSystem.Domain.Factories.Statistics.MatchStatistics
{
    using Core.Domain;
    using Models.Statistics.MatchStatistics;

    public interface IMatchStatisticsFactory : IFactory<MatchStatistics>
    {
        IMatchStatisticsFactory WithHomeTeamGoals(int homeGoals);

        IMatchStatisticsFactory WithAwayTeamGoals(int awayGoals);
    }
}
