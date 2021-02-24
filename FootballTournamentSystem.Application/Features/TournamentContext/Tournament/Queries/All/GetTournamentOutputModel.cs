namespace FootballTournamentSystem.Application.Features.TournamentContext.Tournament.Queries.All
{
    public class GetTournamentOutputModel
    {
        //TODO: IMapfrom later

        public int Id { get; private set; }

        public string Name { get; private set; } = default!;

        public int TotalGroups { get; set; }
    }
}
