namespace FootballTournamentSystem.Person.Application.Features.Coach.Commands.Create
{
    using System;

    public class CreateCoachOutputModel
    {
        public CreateCoachOutputModel(int coachId)
        {
            this.CoachId = coachId;
        }

        public int CoachId { get; }
    }
}
