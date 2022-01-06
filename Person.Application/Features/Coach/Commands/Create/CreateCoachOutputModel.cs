namespace FootballTournamentSystem.Person.Application.Features.Coach.Commands.Create
{
    using System;

    public class CreateCoachOutputModel
    {
        public CreateCoachOutputModel(Guid coachId)
        {
            this.CoachId = coachId;
        }

        public Guid CoachId { get; }
    }
}
