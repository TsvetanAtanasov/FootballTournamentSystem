namespace FootballTournamentSystem.Application.Features.TournamentContext.Team.Common
{
    public class TeamOutputModel
    {
        //TODO: IMapfrom later

        public string Name { get; set; } = default!;

        public string LogoUrl { get; set; } = default!;

        public int YearFounded { get; set; }

        public string PresidentFirstName { get; set; } = default!;

        public string PresidentLastName { get; set; } = default!;

        public string PresidentImageUrl { get; set; } = default!;

        public string CoachFirstName { get; set; } = default!;

        public string CoachLastName { get; set; } = default!;

        public string CoachImageUrl { get; set; } = default!;

        public string Country { get; set; } = default!;

        public string Stadium { get; set; } = default!;

        public int GroupPoints { get; set; }
    }
}
