namespace FootballTournamentSystem.Application.Features.Person.Player.Commands.Create
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
