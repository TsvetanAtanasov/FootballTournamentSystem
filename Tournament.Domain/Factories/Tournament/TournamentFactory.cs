namespace FootballTournamentSystem.Tournament.Domain.Factories.Tournament
{
    using Models.Tournament;

    internal class TournamentFactory : ITournamentFactory
    {
        private string name = default!;
        private int numberOfTeams = default!;
        private string imageUrl = default!;

        public ITournamentFactory WithName(string name)
        {
            this.name = name;
            return this;
        }

        public ITournamentFactory WithNumberOfTeams(int numberOfTeams)
        {
            this.numberOfTeams = numberOfTeams;
            return this;
        }

        public ITournamentFactory WithImageUrl(string imageUrl)
        {
            this.imageUrl = imageUrl;
            return this;
        }

        public Tournament Build() => new Tournament(this.name, this.numberOfTeams, this.imageUrl);
    }
}
