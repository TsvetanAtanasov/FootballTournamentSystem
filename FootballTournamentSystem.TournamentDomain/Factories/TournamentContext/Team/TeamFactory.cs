namespace FootballTournamentSystem.Domain.Factories.TournamentContext.Team
{
    using FootballTournamentSystem.Domain.Models.PersonContext.Coach;
    using FootballTournamentSystem.Domain.Models.PersonContext.President;
    using Models.TournamentContext.Team;

    internal class TeamFactory : ITeamFactory
    {
        private string name = default!;
        private string logoUrl = default!;
        private int yearFounded = default!;
        private President president = default!;
        private Coach coach = default!;
        private string country = default!;
        private string stadium = default!;
        private int groupPoints = default!;

        public ITeamFactory WithName(string name)
        {
            this.name = name;
            return this;
        }

        public ITeamFactory WithLogoUrl(string logoUrl)
        {
            this.logoUrl = logoUrl;
            return this;
        }

        public ITeamFactory WithYearFounded(int yearFounded)
        {
            this.yearFounded = yearFounded;
            return this;
        }

        public ITeamFactory WithPresident(string firstName, string lastName, string imageUrl)
            => this.WithPresident(new President(firstName, lastName, imageUrl));

        public ITeamFactory WithPresident(President president)
        {
            this.president = president;
            return this;
        }

        public ITeamFactory WithCoach(string firstName, string lastName, string imageUrl)
            => this.WithCoach(new Coach(firstName, lastName, imageUrl));

        public ITeamFactory WithCoach(Coach coach)
        {
            this.coach = coach;
            return this;
        }

        public ITeamFactory WithLeague(string country)
        {
            this.country = country;
            return this;
        }

        public ITeamFactory WithStadium(string stadium)
        {
            this.stadium = stadium;
            return this;
        }

        public ITeamFactory WithGroupPoints(int groupPoints)
        {
            this.groupPoints = groupPoints;
            return this;
        }

        public Team Build() => new Team(this.name, this.logoUrl, this.yearFounded, this.president, this.coach, this.country, this.stadium, this.groupPoints);
    }
}
