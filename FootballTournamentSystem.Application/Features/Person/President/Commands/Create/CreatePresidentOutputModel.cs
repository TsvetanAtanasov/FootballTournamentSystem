using System;

namespace FootballTournamentSystem.Application.Features.Person.President.Commands.Create
{
    public class CreatePresidentOutputModel
    {
        public CreatePresidentOutputModel(Guid presidentId)
        {
            this.PresidentId = presidentId;
        }

        public Guid PresidentId { get; }
    }
}
