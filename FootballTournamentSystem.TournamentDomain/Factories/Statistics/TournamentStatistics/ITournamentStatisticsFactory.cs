namespace FootballTournamentSystem.Domain.Factories.StatisticsContext.TournamentStatistics
{
    using Models.TournamentContext.Team;
    using Models.Person.Player;
    using Models.StatisticsContext.TournamentStatistics;
    using global::Common.Domain;

    public interface ITournamentStatisticsFactory : IFactory<TournamentStatistics>
    {
        ITournamentStatisticsFactory WithGoalsScored(int goalsScored);
    }
}
