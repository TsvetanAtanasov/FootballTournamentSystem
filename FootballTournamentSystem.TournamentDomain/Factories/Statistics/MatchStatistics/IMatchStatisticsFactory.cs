namespace FootballTournamentSystem.Domain.Factories.StatisticsContext.MatchStatistics
{
    using global::Common.Domain;
    using Models.StatisticsContext.MatchStatistics;

    public interface IMatchStatisticsFactory : IFactory<MatchStatistics>
    {
        IMatchStatisticsFactory WithHomeTeamGoals(int homeGoals);

        IMatchStatisticsFactory WithAwayTeamGoals(int awayGoals);
    }
}
