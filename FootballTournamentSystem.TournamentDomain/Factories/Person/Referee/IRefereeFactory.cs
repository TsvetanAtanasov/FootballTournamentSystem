namespace FootballTournamentSystem.Domain.Factories.Person.Referee
{
    using Core.Domain;
    using Models.Person.Referee;

    public interface IRefereeFactory : IFactory<Referee>
    {
        IRefereeFactory WithFirstName(string firstName);

        IRefereeFactory WithLastName(string lastName);

        IRefereeFactory WithImageUrl(string imageUrl);
    }
}
