namespace FootballTournamentSystem.Domain.Factories.PersonContext.Player
{
    using global::Common.Domain;
    using Models.PersonContext.Player;

    public interface IPlayerFactory : IFactory<Player>
    {
        IPlayerFactory WithFirstName(string firstName);

        IPlayerFactory WithLastName(string lastName);

        IPlayerFactory WithHeight(double height);

        IPlayerFactory WithWeight(double weight);

        IPlayerFactory WithImageUrl(string imageUrl);
    }
}
