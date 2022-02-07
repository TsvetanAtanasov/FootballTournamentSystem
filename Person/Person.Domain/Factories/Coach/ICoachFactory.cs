namespace FootballTournamentSystem.Person.Domain.Factories.Coach
{
    using Core.Domain;
    using FootballTournamentSystem.Person.Domain.Models.Coach;

    public interface ICoachFactory : IFactory<Coach>
    {
        ICoachFactory WithFirstName(string firstName);

        ICoachFactory WithLastName(string lastName);

        ICoachFactory WithImageUrl(string imageUrl);

        ICoachFactory WithTeamId(int teamId);
    }
}
