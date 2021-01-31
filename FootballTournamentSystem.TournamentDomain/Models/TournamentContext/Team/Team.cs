namespace FootballTournamentSystem.Domain.Models.TournamentContext.Team
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Models.PlayerContext.Player;
    using System.Collections.Generic;
    using System.Linq;
    using FootballTournamentSystem.Domain.Exceptions;

    using static ModelConstants.Common;

    public class Team : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Player> players;

        internal Team(string name, string logoUrl, int yearFounded, string president, string coach, string league, string stadium)
        {
            this.Validate(name, logoUrl, yearFounded, president, coach, league, stadium);

            this.Name = name;
            this.LogoUrl = logoUrl;
            this.YearFounded = yearFounded;
            this.President = president;
            this.Coach = coach;
            this.League = league;
            this.Stadium = stadium;

            this.players = new HashSet<Player>();
        }

        public string Name { get; }

        public string LogoUrl { get; }

        public int YearFounded { get; }

        public string President { get; }

        public string Coach { get; }

        public string League { get; }

        public string Stadium { get; }

        public IReadOnlyCollection<Player> Players => this.players.ToList().AsReadOnly();

        public void AddPlayer(Player player) => this.players.Add(player);

        private void Validate(string name, string logoUrl, int yearFounded, string president, string coach, string league, string stadium)
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
            president,
            MinNameLength,
            MaxNameLength,
            nameof(this.President));

            Guard.ForStringLength<InvalidTeamException>(
            coach,
            MinNameLength,
            MaxNameLength,
            nameof(this.Coach));

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
        }
    }
}
