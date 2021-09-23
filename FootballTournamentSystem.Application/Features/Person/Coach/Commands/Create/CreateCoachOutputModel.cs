namespace FootballTournamentSystem.Application.Features.Person.Coach.Commands.Create
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
