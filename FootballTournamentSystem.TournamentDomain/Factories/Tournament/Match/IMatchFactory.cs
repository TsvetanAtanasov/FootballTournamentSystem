namespace FootballTournamentSystem.Domain.Factories.Tournament.Match
{
    using Core.Domain;
    using Models.Person.Referee;
    using Models.Tournament.Match;
    using Models.Tournament.Team;

    public interface IMatchFactory : IFactory<Match>
    {
        IMatchFactory WithHomeTeam(Team homeTeam);

        IMatchFactory WithAwayTeam(Team awayTeam);
    }
}
