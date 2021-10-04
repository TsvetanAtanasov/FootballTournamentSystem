namespace FootballTournamentSystem.Application.Features.Tournament.Team.Commands.Create
{
    public class CreateTeamOutputModel
    {
        public CreateTeamOutputModel(int teamId)
        {
            this.TeamId = teamId;
        }

        public int TeamId { get; }
    }
}
