namespace FootballTournamentSystem.Application.Features.PersonContext.Coach.Commands.Create
{
    public class CreateCoachOutputModel
    {
        public CreateCoachOutputModel(int coachId)
        {
            this.CoachId = coachId;
        }

        public int CoachId { get; }
    }
}
