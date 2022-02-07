namespace FootballTournamentSystem.Person.Application.Features.President.Commands.Create
{
    using System;

    public class CreatePresidentOutputModel
    {
        public CreatePresidentOutputModel(Guid presidentId)
        {
            this.PresidentId = presidentId;
        }

        public Guid PresidentId { get; }
    }
}
