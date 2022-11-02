namespace FootballTournamentSystem.Person.Application.Features.Referee.Commands.Create
{
    using System;

    public class CreateRefereeOutputModel
    {
        public CreateRefereeOutputModel(int refereeId)
        {
            this.RefereeId = refereeId;
        }

        public int RefereeId { get; }
    }
}
