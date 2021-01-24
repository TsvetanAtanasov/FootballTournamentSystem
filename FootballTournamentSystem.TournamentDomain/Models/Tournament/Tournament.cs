namespace FootballTournamentSystem.TournamentDomain.Models.Tournament
{
    using FootballTournamentSystem.TournamentDomain.Common;
    using FootballTournamentSystem.TournamentDomain.Exceptions;

    public class Tournament : Entity<int>, IAggregateRoot
    {
        public Tournament(
            TournamentType tournamentType,
            int numberOfTeams,
            string imageUrl)
        {
            this.Validate(numberOfTeams, imageUrl);

            this.TournamentType = tournamentType;
            this.NumberOfTeams = numberOfTeams;
            this.ImageUrl = imageUrl;
        }

        public TournamentType TournamentType { get; }

        public int NumberOfTeams { get; }

        public string ImageUrl { get; }

        private void Validate(int numberOfTeams, string imageUrl)
        {
            //TODO: validate tournament types
            Guard.ForPositiveNumber<InvalidTournamentException>(
                numberOfTeams,
                nameof(this.NumberOfTeams));

            Guard.ForValidUrl<InvalidTournamentException>(
                imageUrl,
                nameof(this.ImageUrl));
        }
    }
}
