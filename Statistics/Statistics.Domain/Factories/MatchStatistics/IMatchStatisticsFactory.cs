namespace FootballTournamentSystem.Statistics.Domain.Factories.MatchStatistics
{
    using Core.Domain;
    using FootballTournamentSystem.Statistics.Domain.Models.MatchStatistics;

    public interface IMatchStatisticsFactory : IFactory<MatchStatistics>
    {
        IMatchStatisticsFactory WithHomeTeamGoals(int homeGoals);

        IMatchStatisticsFactory WithAwayTeamGoals(int awayGoals);
    }
}
