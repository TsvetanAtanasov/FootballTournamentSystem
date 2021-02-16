namespace FootballTournamentSystem.Domain.Factories.StatisticsContext.TournamentStatistics
{
    using Models.TournamentContext.Team;
    using Models.PlayerContext.Player;
    using Models.StatisticsContext.TournamentStatistics;

    public interface ITournamentStatisticsFactory : IFactory<TournamentStatistics>
    {
        ITournamentStatisticsFactory WithGoalsScored(int goalsScored);

        ITournamentStatisticsFactory WithGoalScorer(Player goalScorer);

        ITournamentStatisticsFactory WithWinner(Team winner);
    }
}
