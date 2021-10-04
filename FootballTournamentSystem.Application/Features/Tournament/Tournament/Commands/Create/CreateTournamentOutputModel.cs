namespace FootballTournamentSystem.Application.Features.Tournament.Tournament.Commands.Create
{
    public class CreateTournamentOutputModel
    {
        public CreateTournamentOutputModel(int tournamentId)
        {
            this.TournamentId = tournamentId;
        }

        public int TournamentId { get; }
    }
}
