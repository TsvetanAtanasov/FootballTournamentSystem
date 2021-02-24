namespace FootballTournamentSystem.Domain.Models.TournamentContext.Tournament
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Exceptions;
    using System.Collections.Generic;
    using System.Linq;

    using static ModelConstants.Common;

    public class Tournament : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Group> groups;

        internal Tournament(
            string name,
            TournamentType tournamentType,
            int numberOfTeams,
            string imageUrl)
        {
            this.Validate(name, numberOfTeams, imageUrl);

            this.Name = name;
            this.TournamentType = tournamentType;
            this.NumberOfTeams = numberOfTeams;
            this.ImageUrl = imageUrl;

            this.groups = new HashSet<Group>();
        }

        public string Name { get; }

        public TournamentType TournamentType { get; }

        public int NumberOfTeams { get; }

        public string ImageUrl { get; }

        public RoundOf16? RoundOf16 { get; private set; }

        public QuarterFinals? QuarterFinals { get; private set; }

        public SemiFinals? SemiFinals { get; private set; }

        public Final? Final { get; private set; }

        public int PlayerStatisticsId { get; }

        public int TournamentId { get; }

        public IReadOnlyCollection<Group> Groups => this.groups.ToList().AsReadOnly();

        public void AddGroup(Group group) => this.groups.Add(group);

        private void Validate(string name, int numberOfTeams, string imageUrl)
        {
            //TODO: validate tournament types
            Guard.ForStringLength<InvalidPlayerException>(
            name,
            MinNameLength,
            MaxNameLength,
            nameof(this.Name));

            Guard.ForPositiveNumber<InvalidTournamentException>(
                numberOfTeams,
                nameof(this.NumberOfTeams));

            Guard.ForValidUrl<InvalidTournamentException>(
                imageUrl,
                nameof(this.ImageUrl));
        }
    }
}
