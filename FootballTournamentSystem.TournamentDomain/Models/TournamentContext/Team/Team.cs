namespace FootballTournamentSystem.Domain.Models.TournamentContext.Team
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Models.PersonContext.Player;
    using FootballTournamentSystem.Domain.Models.PersonContext.President;
    using FootballTournamentSystem.Domain.Models.PersonContext.Coach;
    using System.Collections.Generic;
    using System.Linq;
    using FootballTournamentSystem.Domain.Exceptions;

    using static ModelConstants.Common;

    public class Team : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Player> players;

        internal Team(string name, string logoUrl, int yearFounded, President president, Coach coach, string league, string stadium, int groupPoints)
        {
            this.Validate(name, logoUrl, yearFounded, league, stadium, groupPoints);

            this.Name = name;
            this.LogoUrl = logoUrl;
            this.YearFounded = yearFounded;
            this.President = president;
            this.Coach = coach;
            this.League = league;
            this.Stadium = stadium;
            this.GroupPoints = groupPoints;

            this.players = new HashSet<Player>();
        }

        public string Name { get; }

        public string LogoUrl { get; }

        public int YearFounded { get; }

        public President President { get; }

        public Coach Coach { get; }

        public string League { get; }

        public string Stadium { get; }

        public int GroupPoints { get; }

        public IReadOnlyCollection<Player> Players => this.players.ToList().AsReadOnly();

        public void AddPlayer(Player player) => this.players.Add(player);

        private void Validate(string name, string logoUrl, int yearFounded, string league, string stadium, int groupPoints)
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
            league,
            MinNameLength,
            MaxNameLength,
            nameof(this.League));

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
