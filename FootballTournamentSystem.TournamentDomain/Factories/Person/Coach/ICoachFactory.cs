namespace FootballTournamentSystem.Domain.Factories.PersonContext.Coach
{
    using Models.PersonContext.Coach;

    public interface ICoachFactory : IFactory<Coach>
    {
        ICoachFactory WithFirstName(string firstName);

        ICoachFactory WithLastName(string lastName);

        ICoachFactory WithImageUrl(string imageUrl);
    }
}
