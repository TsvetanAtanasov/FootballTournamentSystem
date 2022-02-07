namespace FootballTournamentSystem.Person.Domain.Models
{
    using Core.Domain;
    using Core.Domain.Models;
    using Core.Domain.Exceptions;
    using System;

    public abstract class Person : Entity<Guid>, IAggregateRoot
    {
        internal Person(string firstName, string lastName, string imageUrl)
        {
            this.Validate(firstName, lastName, imageUrl);

            this.Id = Guid.NewGuid();

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
