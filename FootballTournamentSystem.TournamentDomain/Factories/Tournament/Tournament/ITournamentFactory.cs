namespace FootballTournamentSystem.Domain.Factories.Tournament.Tournament
{
    using Core.Domain;
    using Models.Tournament.Tournament;

    public interface ITournamentFactory : IFactory<Tournament>
    {
        ITournamentFactory WithName(string name);

        ITournamentFactory WithNumberOfTeams(int numberOfTeams);

        ITournamentFactory WithImageUrl(string imageUrl);
    }
}
