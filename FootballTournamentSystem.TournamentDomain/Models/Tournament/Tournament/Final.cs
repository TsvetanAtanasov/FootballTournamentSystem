namespace FootballTournamentSystem.Domain.Models.Tournament.Tournament
{
    using FootballTournamentSystem.Domain.Models.Tournament.Match;
    using Core.Domain.Models;

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
