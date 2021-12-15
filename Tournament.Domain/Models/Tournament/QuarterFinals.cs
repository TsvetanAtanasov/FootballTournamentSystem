namespace FootballTournamentSystem.Tournament.Domain.Models.Tournament
{
    using FootballTournamentSystem.Tournament.Domain.Models.Match;
    using Core.Domain.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class QuarterFinals : Entity<int>
    {
        private readonly HashSet<Match> matches;

        internal QuarterFinals()
        {
            this.matches = new HashSet<Match>();
        }

        public IReadOnlyCollection<Match> Matches => this.matches.ToList().AsReadOnly();

        public void AddMatch(Match match) 
        {
            //Guard.ForMatchesCount<InvalidFinalsException>(
            //    this.matches,
            //    nameof(QuarterFinals));

            this.matches.Add(match);
        }
    }
}
