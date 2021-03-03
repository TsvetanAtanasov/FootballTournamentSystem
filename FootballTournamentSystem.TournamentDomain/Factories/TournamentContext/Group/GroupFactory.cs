namespace FootballTournamentSystem.Domain.Factories.TournamentContext.Group
{
    using FootballTournamentSystem.Domain.Models.TournamentContext.Group;

    internal class GroupFactory : IGroupFactory
    {
        private string name = default!;

        public IGroupFactory WithName(string name)
        {
            this.name = name;
            return this;
        }

        public Group Build() => new Group(this.name);
    }
}
