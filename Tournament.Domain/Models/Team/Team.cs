namespace FootballTournamentSystem.Tournament.Domain.Models.Team
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Core.Domain.Exceptions;

    using Core.Domain;
    using Core.Domain.Models;

    public class Team : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Guid> playerIds;

        internal Team(string name, string logoUrl, int yearFounded, string country, string stadium, int groupPoints)
        {
            this.Validate(name, logoUrl, yearFounded, country, stadium, groupPoints);

            this.Name = name;
            this.LogoUrl = logoUrl;
            this.YearFounded = yearFounded;
            this.Country = country;
            this.Stadium = stadium;
            this.GroupPoints = groupPoints;

            this.playerIds = new HashSet<Guid>();
        }

        public string Name { get; }

        public string LogoUrl { get; }

        public int YearFounded { get; }

        public string Country { get; }

        public string Stadium { get; }

        // Team's place in the group will be calculated by this property ( no need of group ranking )
        public int GroupPoints { get; }

        public Guid PresidentId { get; set; }

        public Guid CoachId { get; private set; }

        public IReadOnlyCollection<Guid> PlayerIds => this.playerIds.ToList().AsReadOnly();

        public void AddPlayer(Guid playerId) => this.playerIds.Add(playerId);

        public void AddPresident(Guid presidentId) => this.PresidentId = presidentId;

        public void AddCoach(Guid coachId) => this.CoachId = coachId;

        private void Validate(string name, string logoUrl, int yearFounded, string country, string stadium, int groupPoints)
        {
            Guard.ForStringLength<InvalidTeamException>(
            name,
            ModelConstants.Common.MinNameLength,
            ModelConstants.Common.MaxNameLength,
            nameof(this.Name));

            Guard.ForValidUrl<InvalidTeamException>(
            logoUrl,
            nameof(this.LogoUrl));

            Guard.ForPositiveNumber<InvalidTeamException>(
            yearFounded,
            nameof(this.YearFounded));

            Guard.ForStringLength<InvalidTeamException>(
            country,
            ModelConstants.Common.MinNameLength,
            ModelConstants.Common.MaxNameLength,
            nameof(this.Country));

            Guard.ForStringLength<InvalidTeamException>(
            stadium,
            ModelConstants.Common.MinNameLength,
            ModelConstants.Common.MaxNameLength,
            nameof(this.Stadium));

            Guard.ForPositiveNumber<InvalidTeamException>(
            groupPoints,
            nameof(this.GroupPoints));
        }
    }
}
