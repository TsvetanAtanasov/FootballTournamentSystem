namespace FootballTournamentSystem.Domain.Factories.PersonContext.President
{
    using Models.PersonContext.President;

    public interface IPresidentFactory : IFactory<President>
    {
        IPresidentFactory WithFirstName(string firstName);

        IPresidentFactory WithLastName(string lastName);

        IPresidentFactory WithImageUrl(string imageUrl);
    }
}
