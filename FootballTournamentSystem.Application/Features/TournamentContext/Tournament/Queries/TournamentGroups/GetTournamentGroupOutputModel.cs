namespace FootballTournamentSystem.Application.Features.TournamentContext.Tournament.Queries.TournamentGroups
{
    using System.Collections.Generic;

    public class GetTournamentGroupOutputModel
    {
        public GetTournamentGroupOutputModel(
            int id,
            string name,
            IEnumerable<string> teamNames,
            IEnumerable<string> teamLogos)
        {
            this.Id = id;
            this.Name = name;
            this.TeamNames = teamNames;
            this.TeamLogos = teamLogos;
        }
        public int Id { get; private set; }

        public string Name { get; private set; } = default!;

        public IEnumerable<string> TeamNames { get; set; } = default!;

        public IEnumerable<string> TeamLogos { get; set; } = default!;
    }
}
