namespace FootballTournamentSystem.Domain.Factories.TournamentContext.Match
{
    using Models.PersonContext.Referee;
    using Models.TournamentContext.Match;
    using Models.TournamentContext.Team;

    internal class MatchFactory : IMatchFactory
    {
        private Team homeTeam = default!;
        private Team awayTeam = default!;
        private Referee referee = default!;

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
