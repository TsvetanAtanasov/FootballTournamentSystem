namespace FootballTournamentSystem.Domain.Models.Tournament.Tournament
{
    using FootballTournamentSystem.Domain.Models.Tournament.Team;
    using FootballTournamentSystem.Domain.Models.Tournament.Match;
    using FootballTournamentSystem.Domain.Exceptions;
    using System.Collections.Generic;
    using System.Linq;
    using global::Common.Domain.Models;

    public class Group : Entity<int>
    {
        private readonly HashSet<Team> teams;
        private readonly HashSet<Match> matches;

        internal Group(
            string name)
        {
            this.Validate(name);

            this.Name = name;

            this.teams = new HashSet<Team>();
            this.matches = new HashSet<Match>();
        }

        public string Name { get; }

        public IReadOnlyCollection<Team> Teams => this.teams.ToList().AsReadOnly();

        public IReadOnlyCollection<Match> Matches => this.matches.ToList().AsReadOnly();

        public void AddTeam(Team team) => this.teams.Add(team);

        public void AddMatch(Match match) => this.matches.Add(match);

        private void Validate(string name)
        {
            Guard.ForStringLength<InvalidGroupException>(
            name,
            ModelConstants.Common.MinNameLength,
            ModelConstants.Common.MaxNameLength,
            nameof(this.Name));
        }
    }
}
