namespace FootballTournamentSystem.Domain.Models.TournamentContext.Tournament
{
    using FootballTournamentSystem.Domain.Models.TournamentContext.Match;
    using global::Common.Domain.Models;

    public class Final : Entity<int>
    {
        internal Final()
        {
            this.Match = default!;
        }

        public Match Match { get; private set; }

        public void AddPresident(Match match) => this.Match = match;
    }
}
