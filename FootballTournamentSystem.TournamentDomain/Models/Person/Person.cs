namespace FootballTournamentSystem.Domain.Models.PersonContext
{
    using FootballTournamentSystem.Domain.Exceptions;
    using global::Common.Domain;
    using global::Common.Domain.Models;

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
            ModelConstants.Common.MinNameLength,
            ModelConstants.Common.MaxNameLength,
            nameof(this.FirstName));

            Guard.ForStringLength<InvalidPlayerException>(
            lastName,
            ModelConstants.Common.MinNameLength,
            ModelConstants.Common.MaxNameLength,
            nameof(this.LastName));

            Guard.ForValidUrl<InvalidPlayerException>(
            imageUrl,
            nameof(this.ImageUrl));
        }
    }
}
