namespace FootballTournamentSystem.Application.Features.TournamentContext.Tournament.Queries.TournamentGroups
{
    using System.Collections.Generic;

    public class GetTournamentGroupOutputModel
    {
        // return group ranking also
        public int Id { get; private set; }

        public string Name { get; private set; } = default!;

        public IEnumerable<string> TeamNames { get; set; } = default!;

        public IEnumerable<string> TeamLogos { get; set; } = default!;
    }
}
