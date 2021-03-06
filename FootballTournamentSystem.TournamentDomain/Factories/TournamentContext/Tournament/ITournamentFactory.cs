﻿namespace FootballTournamentSystem.Domain.Factories.TournamentContext.Tournament
{
    using Models.TournamentContext.Tournament;

    public interface ITournamentFactory : IFactory<Tournament>
    {
        ITournamentFactory WithName(string name);

        ITournamentFactory WithTournamentType(TournamentType tournamentType);

        ITournamentFactory WithNumberOfTeams(int numberOfTeams);

        ITournamentFactory WithImageUrl(string imageUrl);
    }
}
