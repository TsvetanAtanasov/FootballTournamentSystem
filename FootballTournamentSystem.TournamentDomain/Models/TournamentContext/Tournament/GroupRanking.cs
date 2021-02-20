namespace FootballTournamentSystem.Domain.Models.TournamentContext.Tournament
{
    using FootballTournamentSystem.Domain.Common;

    public class GroupRanking : Entity<int>
    {
        internal GroupRanking(Group group)
        {
            this.Group = group;
        }

        public Group Group { get; }
    }
}
