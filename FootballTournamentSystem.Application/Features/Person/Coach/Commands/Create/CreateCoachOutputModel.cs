using System;

namespace FootballTournamentSystem.Application.Features.Person.Coach.Commands.Create
{
    public class CreateCoachOutputModel
    {
        public CreateCoachOutputModel(Guid coachId)
        {
            this.CoachId = coachId;
        }

        public Guid CoachId { get; }
    }
}
