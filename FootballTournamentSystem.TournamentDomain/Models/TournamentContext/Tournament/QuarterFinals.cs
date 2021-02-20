namespace FootballTournamentSystem.Domain.Models.TournamentContext.Tournament
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Models.TournamentContext.Match;
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

        public void AddMatch(Match match) => this.matches.Add(match);
    }
}
