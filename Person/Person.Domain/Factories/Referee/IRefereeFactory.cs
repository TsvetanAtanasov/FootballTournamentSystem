namespace FootballTournamentSystem.Person.Domain.Factories.Referee
{
    using Core.Domain;
    using FootballTournamentSystem.Person.Domain.Models.Referee;

    public interface IRefereeFactory : IFactory<Referee>
    {
        IRefereeFactory WithFirstName(string firstName);

        IRefereeFactory WithLastName(string lastName);

        IRefereeFactory WithImageUrl(string imageUrl);
    }
}
