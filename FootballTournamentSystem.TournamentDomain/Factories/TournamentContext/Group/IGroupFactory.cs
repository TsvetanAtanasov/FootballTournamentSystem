namespace FootballTournamentSystem.Domain.Factories.TournamentContext.Group
{
    using Models.TournamentContext.Group;

    public interface IGroupFactory : IFactory<Group>
    {
        IGroupFactory WithName(string name);
    }
}
