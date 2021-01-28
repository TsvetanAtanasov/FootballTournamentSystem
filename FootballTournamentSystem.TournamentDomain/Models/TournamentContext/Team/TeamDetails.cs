namespace FootballTournamentSystem.Domain.Models.TournamentContext.Team
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Exceptions;

    using static ModelConstants.Common;

    public class TeamDetails : ValueObject
    {
        internal TeamDetails(string name, string logoUrl, int yearFounded, string president, string coach, string league, string stadium)
        {
            this.Validate(name, logoUrl,yearFounded, president, coach, league, stadium);

            this.Name = name;
            this.LogoUrl = logoUrl;
            this.YearFounded = yearFounded;
            this.President = president;
            this.Coach = coach;
            this.League = league;
            this.Stadium = stadium;
        }

        public string Name { get; }

        public string LogoUrl { get; }

        public int YearFounded { get; }

        public string President { get; }

        public string Coach { get; }

        public string League { get; }

        public string Stadium { get; }


        private void Validate(string name, string logoUrl, int yearFounded, string president, string coach, string league, string stadium)
        {
            Guard.ForStringLength<InvalidTeamDetailsException>(
            name,
            MinNameLength,
            MaxNameLength,
            nameof(this.Name));

            Guard.ForValidUrl<InvalidTeamDetailsException>(
            logoUrl,
            nameof(this.LogoUrl));

            Guard.ForPositiveNumber<InvalidTeamDetailsException>(
            yearFounded,
            nameof(this.YearFounded));

            Guard.ForStringLength<InvalidTeamDetailsException>(
            president,
            MinNameLength,
            MaxNameLength,
            nameof(this.President));

            Guard.ForStringLength<InvalidTeamDetailsException>(
            coach,
            MinNameLength,
            MaxNameLength,
            nameof(this.Coach));

            Guard.ForStringLength<InvalidTeamDetailsException>(
            league,
            MinNameLength,
            MaxNameLength,
            nameof(this.League));

            Guard.ForStringLength<InvalidTeamDetailsException>(
            stadium,
            MinNameLength,
            MaxNameLength,
            nameof(this.Stadium));
        }
    }
}
