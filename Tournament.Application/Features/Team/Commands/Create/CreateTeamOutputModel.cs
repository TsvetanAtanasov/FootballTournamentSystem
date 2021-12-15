namespace FootballTournamentSystem.Tournament.Application.Features.Team.Commands.Create
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
