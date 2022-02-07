namespace FootballTournamentSystem.Tournament.Domain.Factories.Match
{
    using Core.Domain;
    using Models.Match;
    using Models.Team;

    public interface IMatchFactory : IFactory<Match>
    {
        IMatchFactory WithHomeTeam(Team homeTeam);

        IMatchFactory WithAwayTeam(Team awayTeam);
    }
}
