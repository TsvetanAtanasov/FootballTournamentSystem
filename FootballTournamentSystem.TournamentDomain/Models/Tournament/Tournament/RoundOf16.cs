namespace FootballTournamentSystem.Domain.Models.Tournament.Tournament
{
    using FootballTournamentSystem.Domain.Models.Tournament.Match;
    using Core.Domain.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class RoundOf16 : Entity<int>
    {
        private readonly HashSet<Match> matches;

        internal RoundOf16()
        {
            this.matches = new HashSet<Match>();
        }

        public IReadOnlyCollection<Match> Matches => this.matches.ToList().AsReadOnly();

        public void AddMatch(Match match)
        {
            //Guard.ForMatchesCount<InvalidFinalsException>(
            //this.matches,
            //nameof(RoundOf16));

            this.matches.Add(match);
        }
    }
}
