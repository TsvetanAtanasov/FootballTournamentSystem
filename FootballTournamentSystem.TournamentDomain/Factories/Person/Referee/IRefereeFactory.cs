namespace FootballTournamentSystem.Domain.Factories.PersonContext.Referee
{
    using global::Common.Domain;
    using Models.PersonContext.Referee;

    public interface IRefereeFactory : IFactory<Referee>
    {
        IRefereeFactory WithFirstName(string firstName);

        IRefereeFactory WithLastName(string lastName);

        IRefereeFactory WithImageUrl(string imageUrl);
    }
}
