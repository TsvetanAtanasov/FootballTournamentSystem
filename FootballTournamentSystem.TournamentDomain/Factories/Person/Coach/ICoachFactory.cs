namespace FootballTournamentSystem.Domain.Factories.PersonContext.Coach
{
    using global::Common.Domain;
    using Models.PersonContext.Coach;

    public interface ICoachFactory : IFactory<Coach>
    {
        ICoachFactory WithFirstName(string firstName);

        ICoachFactory WithLastName(string lastName);

        ICoachFactory WithImageUrl(string imageUrl);
    }
}
