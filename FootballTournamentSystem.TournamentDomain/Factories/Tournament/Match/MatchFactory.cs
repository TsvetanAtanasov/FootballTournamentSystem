namespace FootballTournamentSystem.Domain.Factories.Tournament.Match
{
    using Models.Person.Referee;
    using Models.Tournament.Match;
    using Models.Tournament.Team;

    internal class MatchFactory : IMatchFactory
    {
        private Team homeTeam = default!;
        private Team awayTeam = default!;

        public IMatchFactory WithHomeTeam(Team homeTeam)
        {
            this.homeTeam = homeTeam;
            return this;
        }

        public IMatchFactory WithAwayTeam(Team awayTeam)
        {
            this.awayTeam = awayTeam;
            return this;
        }

        public Match Build() => new Match(this.homeTeam, this.awayTeam);
    }
}
