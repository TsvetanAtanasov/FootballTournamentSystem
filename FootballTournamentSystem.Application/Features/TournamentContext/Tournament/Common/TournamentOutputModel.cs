namespace FootballTournamentSystem.Application.Features.TournamentContext.Tournament.Common
{
    using Domain.Models.TournamentContext.Tournament;

    public class TournamentOutputModel
    {
        //TODO: IMapfrom later

        public int Id { get; private set; }

        public string Name { get; private set; } = default!;

        public TournamentType TournamentType { get; private set; } = default!;

        public int TotalGroups { get; set; }
    }
}
