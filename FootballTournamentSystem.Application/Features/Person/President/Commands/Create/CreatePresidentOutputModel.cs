namespace FootballTournamentSystem.Application.Features.PersonContext.President.Commands.Create
{
    public class CreatePresidentOutputModel
    {
        public CreatePresidentOutputModel(int presidentId)
        {
            this.PresidentId = presidentId;
        }

        public int PresidentId { get; }
    }
}
