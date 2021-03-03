namespace FootballTournamentSystem.Application.Features.TournamentContext.Tournament.Commands.Groups
{
    public class AddGroupToTournamentOutputModel
    {
        public AddGroupToTournamentOutputModel(int groupId)
        {
            this.GrouptId = groupId;
        }

        public int GrouptId { get; }
    }
}
