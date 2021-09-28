using System;

namespace FootballTournamentSystem.Application.Features.Person.Referee.Commands.Create
{
    public class CreateRefereeOutputModel
    {
        public CreateRefereeOutputModel(Guid refereeId)
        {
            this.RefereeId = refereeId;
        }

        public Guid RefereeId { get; }
    }
}
