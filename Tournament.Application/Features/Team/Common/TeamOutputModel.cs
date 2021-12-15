namespace FootballTournamentSystem.Tournament.Application.Features.Team.Common
{
    public class TeamOutputModel
    {
        public TeamOutputModel(
            int id,
            string name,
            string logoUrl,
            int yearFounded,
            string presidentFirstName,
            string presidentLastName,
            string presidentImageUrl,
            string coachFirstName,
            string coachLastName,
            string coachImageUrl,
            string country,
            string stadium,
            int groupPoints)
        {
            this.Id = id;
            this.Name = name;
            this.LogoUrl = logoUrl;
            this.YearFounded = yearFounded;
            this.PresidentFirstName = presidentFirstName;
            this.PresidentImageUrl = presidentImageUrl;
            this.CoachFirstName = coachFirstName;
            this.CoachLastName = coachLastName;
            this.CoachImageUrl = coachImageUrl;
            this.Country = country;
            this.Stadium = stadium;
            this.GroupPoints = groupPoints;
        }

        //TODO: IMapfrom later

        public int Id { get; private set; }

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
