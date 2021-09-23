namespace FootballTournamentSystem.Domain.Factories.Person.Player
{
    using global::Common.Domain;
    using Models.Person.Player;

    public interface IPlayerFactory : IFactory<Player>
    {
        IPlayerFactory WithFirstName(string firstName);

        IPlayerFactory WithLastName(string lastName);

        IPlayerFactory WithHeight(double height);

        IPlayerFactory WithWeight(double weight);

        IPlayerFactory WithImageUrl(string imageUrl);
    }
}
