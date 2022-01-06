namespace FootballTournamentSystem.Person.Domain.Factories.Player
{
    using Core.Domain;
    using FootballTournamentSystem.Person.Domain.Models.Player;

    public interface IPlayerFactory : IFactory<Player>
    {
        IPlayerFactory WithFirstName(string firstName);

        IPlayerFactory WithLastName(string lastName);

        IPlayerFactory WithHeight(double height);

        IPlayerFactory WithWeight(double weight);

        IPlayerFactory WithImageUrl(string imageUrl);

        IPlayerFactory WithTeamId(int teamId);
    }
}
