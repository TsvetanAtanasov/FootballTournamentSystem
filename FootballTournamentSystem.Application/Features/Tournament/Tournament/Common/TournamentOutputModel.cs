namespace FootballTournamentSystem.Application.Features.TournamentContext.Tournament.Common
{
    using Domain.Models.TournamentContext.Tournament;

    public class TournamentOutputModel
    {
        public TournamentOutputModel(
            int id,
            string name,
            int totalGroups)
        {
            this.Id = id;
            this.Name = name;
            this.TotalGroups = totalGroups;
        }
        //TODO: IMapfrom later

        public int Id { get; private set; }

        public string Name { get; private set; } = default!;

        public int TotalGroups { get; set; }
    }
}
