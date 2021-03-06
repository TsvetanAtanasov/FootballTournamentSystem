﻿namespace FootballTournamentSystem.Domain.Factories.TournamentContext.Tournament
{
    using FootballTournamentSystem.Domain.Models.TournamentContext.Tournament;

    internal class TournamentFactory : ITournamentFactory
    {
        private string name = default!;
        private TournamentType tournamentType = default!;
        private int numberOfTeams = default!;
        private string imageUrl = default!;

        public ITournamentFactory WithName(string name)
        {
            this.name = name;
            return this;
        }

        public ITournamentFactory WithTournamentType(TournamentType tournamentType)
        {
            this.tournamentType = tournamentType;
            return this;
        }

        public ITournamentFactory WithNumberOfTeams(int numberOfTeams)
        {
            this.numberOfTeams = numberOfTeams;
            return this;
        }

        public ITournamentFactory WithImageUrl(string imageUrl)
        {
            this.imageUrl = imageUrl;
            return this;
        }

        public Tournament Build() => new Tournament(this.name, this.tournamentType, this.numberOfTeams, this.imageUrl);
    }
}
