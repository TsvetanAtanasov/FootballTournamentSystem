namespace FootballTournamentSystem.Domain.Models.PlayerContext.Player
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Exceptions;
    using static ModelConstants.Common;

    public class Player : Entity<int>, IAggregateRoot
    {
        internal Player(string firstName, string lastName, double height, double weight, string imageUrl)
        {
            this.Validate(firstName, lastName, height, weight, imageUrl);

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Height = height;
            this.Weight = weight;
            this.ImageUrl = imageUrl;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public double Height { get; }

        public double Weight { get; }

        public string ImageUrl { get; }

        public int PlayerStatisticsId { get; }

        private void Validate(string firstName, string lastName, double height, double weight, string imageUrl)
        {
            Guard.ForStringLength<InvalidPlayerException>(
            firstName,
            MinNameLength,
            MaxNameLength,
            nameof(this.FirstName));

            Guard.ForStringLength<InvalidPlayerException>(
            lastName,
            MinNameLength,
            MaxNameLength,
            nameof(this.LastName));

            Guard.ForPositiveNumber<InvalidPlayerException>(
            height,
            nameof(this.Height));

            Guard.ForPositiveNumber<InvalidPlayerException>(
            weight,
            nameof(this.Weight));

            Guard.ForValidUrl<InvalidPlayerException>(
            imageUrl,
            nameof(this.ImageUrl));
        }
    }
}
