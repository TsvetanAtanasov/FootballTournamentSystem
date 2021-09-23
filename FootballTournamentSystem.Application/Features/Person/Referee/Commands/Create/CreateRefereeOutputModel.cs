namespace FootballTournamentSystem.Application.Features.Person.Referee.Commands.Create
{
    public class CreateRefereeOutputModel
    {
        public CreateRefereeOutputModel(int refereeId)
        {
            this.RefereeId = refereeId;
        }

        public int RefereeId { get; }
    }
}
