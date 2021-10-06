namespace FootballTournamentSystem.Domain.Factories.Person.President
{
    using Core.Domain;
    using Models.Person.President;

    public interface IPresidentFactory : IFactory<President>
    {
        IPresidentFactory WithFirstName(string firstName);

        IPresidentFactory WithLastName(string lastName);

        IPresidentFactory WithImageUrl(string imageUrl);

        IPresidentFactory WithTeamId(int teamId);
    }
}
