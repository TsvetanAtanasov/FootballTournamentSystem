namespace FootballTournamentSystem.Domain.Factories.PlayerContext.Player
{
    using Models.PlayerContext.Player;

    public interface IPlayerFactory : IFactory<Player>
    {
        IPlayerFactory WithFirstName(string firstName);

        IPlayerFactory WithLastName(string lastName);

        IPlayerFactory WithHeight(double height);

        IPlayerFactory WithWeight(double weight);

        IPlayerFactory WithImageUrl(string imageUrl);
    }
}
