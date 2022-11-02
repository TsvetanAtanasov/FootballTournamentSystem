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
        private readonly HashSet<Guid> playerGuids;

        internal Team(string name, string logoUrl, int yearFounded, string country, string stadium, int groupPoints)
        {
            this.Validate(name, logoUrl, yearFounded, country, stadium, groupPoints);

            this.Name = name;
            this.LogoUrl = logoUrl;
            this.YearFounded = yearFounded;
            this.Country = country;
            this.Stadium = stadium;
            this.GroupPoints = groupPoints;

            this.playerGuids = new HashSet<Guid>();
        }

        public string Name { get; }

        public string LogoUrl { get; }

        public int YearFounded { get; }

        public string Country { get; }

        public string Stadium { get; }

        // Team's place in the group will be calculated by this property ( no need of group ranking )
        public int GroupPoints { get; }

        public Guid? PresidentGuid { get; set; }

        public Guid? CoachGuid { get; private set; }

        public IReadOnlyCollection<Guid> PlayerGuids => this.playerGuids.ToList().AsReadOnly();

        public void AddPlayer(Guid playerGuid) => this.playerGuids.Add(playerGuid);

        public void AddPresident(Guid presidentGuid) => this.PresidentGuid = presidentGuid;

        public void AddCoach(Guid coachGuid) => this.CoachGuid = coachGuid;

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

            Guard.ForNotNegativeNumber<InvalidTeamException>(
            groupPoints,
            nameof(this.GroupPoints));
        }
    }
}
