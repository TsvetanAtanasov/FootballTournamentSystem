namespace FootballTournamentSystem.Domain.Factories.Statistics.TournamentStatistics
{
    using Models.Tournament.Team;
    using Models.Person.Player;
    using Models.Statistics.TournamentStatistics;
    using Core.Domain;

    public interface ITournamentStatisticsFactory : IFactory<TournamentStatistics>
    {
        ITournamentStatisticsFactory WithGoalsScored(int goalsScored);
    }
}
