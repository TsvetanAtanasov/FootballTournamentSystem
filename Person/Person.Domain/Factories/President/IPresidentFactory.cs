namespace FootballTournamentSystem.Person.Domain.Factories.President
{
    using Core.Domain;
    using FootballTournamentSystem.Person.Domain.Models.President;

    public interface IPresidentFactory : IFactory<President>
    {
        IPresidentFactory WithFirstName(string firstName);

        IPresidentFactory WithLastName(string lastName);

        IPresidentFactory WithImageUrl(string imageUrl);

        IPresidentFactory WithTeamId(int teamId);
    }
}
