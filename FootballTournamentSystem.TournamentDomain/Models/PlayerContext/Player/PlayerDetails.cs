namespace FootballTournamentSystem.Domain.Models.PlayerContext.Player
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Exceptions;
    using static ModelConstants.Common;

    public class PlayerDetails : ValueObject
    {
        internal PlayerDetails(string firstName, string lastName, double height, double weight, string imageUrl)
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


        private void Validate(string firstName, string lastName, double height, double weight, string imageUrl)
        {
            Guard.ForStringLength<InvalidPlayerDetailsException>(
            firstName,
            MinNameLength,
            MaxNameLength,
            nameof(this.FirstName));

            Guard.ForStringLength<InvalidPlayerDetailsException>(
            lastName,
            MinNameLength,
            MaxNameLength,
            nameof(this.LastName));

            Guard.ForPositiveNumber<InvalidPlayerDetailsException>(
            height,
            nameof(this.Height));

            Guard.ForPositiveNumber<InvalidPlayerDetailsException>(
            weight,
            nameof(this.Weight));

            Guard.ForValidUrl<InvalidPlayerDetailsException>(
            imageUrl,
            nameof(this.ImageUrl));
        }
    }
}
