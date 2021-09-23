namespace FootballTournamentSystem.Application.Features.Person.President.Commands.Create
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
