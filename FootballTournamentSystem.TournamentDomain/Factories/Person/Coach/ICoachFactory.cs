namespace FootballTournamentSystem.Domain.Factories.Person.Coach
{
    using Core.Domain;
    using Models.Person.Coach;

    public interface ICoachFactory : IFactory<Coach>
    {
        ICoachFactory WithFirstName(string firstName);

        ICoachFactory WithLastName(string lastName);

        ICoachFactory WithImageUrl(string imageUrl);
    }
}
