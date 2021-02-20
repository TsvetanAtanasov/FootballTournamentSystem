namespace FootballTournamentSystem.Domain.Models.TournamentContext.Tournament
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Models.TournamentContext.Match;
    using System.Collections.Generic;
    using System.Linq;

    public class Final : Entity<int>
    {
        internal Final(Match match)
        {
            this.Match = match;
        }

        public Match Match { get; }
    }
}
