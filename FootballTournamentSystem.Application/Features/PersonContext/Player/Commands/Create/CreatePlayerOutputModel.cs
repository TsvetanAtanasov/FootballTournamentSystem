namespace FootballTournamentSystem.Application.Features.PersonContext.Player.Commands.Create
{
    public class CreatePlayerOutputModel
    {
        public CreatePlayerOutputModel(int playerId)
        {
            this.PlayerId = playerId;
        }

        public int PlayerId { get; }
    }
}
