namespace FootballTournamentSystem.Domain.Models.TournamentContext.Tournament
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Exceptions;
    using System.Collections.Generic;
    using System.Linq;

    public class Tournament : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Group> groups;

        public Tournament(
            TournamentType tournamentType,
            int numberOfTeams,
            string imageUrl)
        {
            this.Validate(numberOfTeams, imageUrl);

            this.TournamentType = tournamentType;
            this.NumberOfTeams = numberOfTeams;
            this.ImageUrl = imageUrl;

            this.groups = new HashSet<Group>();
        }

        public TournamentType TournamentType { get; }

        public int NumberOfTeams { get; }

        public string ImageUrl { get; }

        public int PlayerStatisticsId { get; }

        public int TournamentId { get; }

        public IReadOnlyCollection<Group> Groups => this.groups.ToList().AsReadOnly();

        public void AddGroup(Group group) => this.groups.Add(group);

        private void Validate(int numberOfTeams, string imageUrl)
        {
            //TODO: validate tournament types
            Guard.ForPositiveNumber<InvalidTournamentException>(
                numberOfTeams,
                nameof(this.NumberOfTeams));

            Guard.ForValidUrl<InvalidTournamentException>(
                imageUrl,
                nameof(this.ImageUrl));
        }
    }
}
