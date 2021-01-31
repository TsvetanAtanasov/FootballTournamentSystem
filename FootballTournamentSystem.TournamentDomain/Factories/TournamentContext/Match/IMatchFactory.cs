namespace FootballTournamentSystem.Domain.Factories.TournamentContext.Match
{
    using Models.TournamentContext.Match;
    using Models.TournamentContext.Team;

    public interface IMatchFactory : IFactory<Match>
    {
        IMatchFactory WithHomeTeam(Team homeTeam);

        IMatchFactory WithAwayTeam(Team awayTeam);
    }
}
