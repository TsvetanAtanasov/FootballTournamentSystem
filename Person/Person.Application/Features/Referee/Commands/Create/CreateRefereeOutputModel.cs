namespace FootballTournamentSystem.Person.Application.Features.Referee.Commands.Create
{
    using System;

    public class CreateRefereeOutputModel
    {
        public CreateRefereeOutputModel(Guid refereeId)
        {
            this.RefereeId = refereeId;
        }

        public Guid RefereeId { get; }
    }
}
