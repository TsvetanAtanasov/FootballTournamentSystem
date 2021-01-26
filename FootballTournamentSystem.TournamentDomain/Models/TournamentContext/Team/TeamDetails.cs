namespace FootballTournamentSystem.Domain.Models.TournamentContext.Team
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Exceptions;

    public class TeamDetails : ValueObject
    {
        internal TeamDetails(string name, string logoUrl, int yearFounded, string president, string coach, string league, string stadium)
        {
            this.Validate(name, logoUrl,yearFounded, president, coach, league, stadium);
            // todo add more properties
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
            // add constants and change validations
            Guard.ForPositiveNumber<InvalidTeamDetailsException>(
            name,
            nameof(this.Name));

            Guard.ForValidUrl<InvalidTeamDetailsException>(
            logoUrl,
            nameof(this.LogoUrl));

            Guard.ForPositiveNumber<InvalidTeamDetailsException>(
            yearFounded,
            nameof(this.YearFounded));

            Guard.ForPositiveNumber<InvalidTeamDetailsException>(
            president,
            nameof(this.President));

            Guard.ForPositiveNumber<InvalidTeamDetailsException>(
            coach,
            nameof(this.Coach));

            Guard.ForPositiveNumber<InvalidTeamDetailsException>(
            league,
            nameof(this.League));

            Guard.ForPositiveNumber<InvalidTeamDetailsException>(
            stadium,
            nameof(this.Stadium));
        }
    }
}
