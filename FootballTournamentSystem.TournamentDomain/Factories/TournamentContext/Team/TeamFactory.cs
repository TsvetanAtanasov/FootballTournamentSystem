namespace FootballTournamentSystem.Domain.Factories.TournamentContext.Team
{
    using Models.TournamentContext.Team;

    internal class TeamFactory : ITeamFactory
    {
        private string name = default!;
        private string logoUrl = default!;
        private int yearFounded = default!;
        private string president = default!;
        private string coach = default!;
        private string league = default!;
        private string stadium = default!;

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

        public ITeamFactory WithPresident(string president)
        {
            this.president = president;
            return this;
        }

        public ITeamFactory WithCoach(string coach)
        {
            this.coach = coach;
            return this;
        }

        public ITeamFactory WithLeague(string league)
        {
            this.league = league;
            return this;
        }

        public ITeamFactory WithStadium(string stadium)
        {
            this.stadium = stadium;
            return this;
        }

        public Team Build() => new Team(this.name, this.logoUrl, this.yearFounded, this.president, this.coach, this.league, this.stadium);
    }
}
