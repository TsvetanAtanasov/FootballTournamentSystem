namespace FootballTournamentSystem.Domain.Models.PersonContext
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Exceptions;
    using static ModelConstants.Common;

    public abstract class Person : Entity<int>, IAggregateRoot
    {
        public Person(string firstName, string lastName, string imageUrl)
        {
            this.Validate(firstName, lastName, imageUrl);

            this.FirstName = firstName;
            this.LastName = lastName;
            this.ImageUrl = imageUrl;
        }

        protected Person()
        {
            this.FirstName = default!;
            this.LastName = default!;
            this.ImageUrl = default!;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public string ImageUrl { get; }

        private void Validate(string firstName, string lastName, string imageUrl)
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

            Guard.ForValidUrl<InvalidPlayerException>(
            imageUrl,
            nameof(this.ImageUrl));
        }
    }
}
