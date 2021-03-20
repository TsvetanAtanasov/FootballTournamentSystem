namespace FootballTournamentSystem.Domain.Models.TournamentContext.Team
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Models.PersonContext.Player;
    using System.Collections.Generic;
    using System.Linq;
    using FootballTournamentSystem.Domain.Exceptions;

    using static ModelConstants.Common;

    public class Team : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<int> playerIds;

        internal Team(string name, string logoUrl, int yearFounded, string country, string stadium, int groupPoints)
        {
            this.Validate(name, logoUrl, yearFounded, country, stadium, groupPoints);

            this.Name = name;
            this.LogoUrl = logoUrl;
            this.YearFounded = yearFounded;
            this.Country = country;
            this.Stadium = stadium;
            this.GroupPoints = groupPoints;

            this.playerIds = new HashSet<int>();
        }

        public string Name { get; }

        public string LogoUrl { get; }

        public int YearFounded { get; }

        public string Country { get; }

        public string Stadium { get; }

        // Team's place in the group will be calculated by this property ( no need of group ranking )
        public int GroupPoints { get; }

        public IReadOnlyCollection<int> PlayerIds => this.playerIds.ToList().AsReadOnly();

        public void AddPlayer(int playerId) => this.playerIds.Add(playerId);

        private void Validate(string name, string logoUrl, int yearFounded, string country, string stadium, int groupPoints)
        {
            Guard.ForStringLength<InvalidTeamException>(
            name,
            MinNameLength,
            MaxNameLength,
            nameof(this.Name));

            Guard.ForValidUrl<InvalidTeamException>(
            logoUrl,
            nameof(this.LogoUrl));

            Guard.ForPositiveNumber<InvalidTeamException>(
            yearFounded,
            nameof(this.YearFounded));

            Guard.ForStringLength<InvalidTeamException>(
            country,
            MinNameLength,
            MaxNameLength,
            nameof(this.Country));

            Guard.ForStringLength<InvalidTeamException>(
            stadium,
            MinNameLength,
            MaxNameLength,
            nameof(this.Stadium));

            Guard.ForPositiveNumber<InvalidTeamException>(
            groupPoints,
            nameof(this.GroupPoints));
        }
    }
}
