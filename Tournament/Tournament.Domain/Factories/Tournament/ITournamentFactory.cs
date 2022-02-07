namespace FootballTournamentSystem.Tournament.Domain.Factories.Tournament
{
    using Core.Domain;
    using Models.Tournament;

    public interface ITournamentFactory : IFactory<Tournament>
    {
        ITournamentFactory WithName(string name);

        ITournamentFactory WithNumberOfTeams(int numberOfTeams);

        ITournamentFactory WithImageUrl(string imageUrl);
    }
}
