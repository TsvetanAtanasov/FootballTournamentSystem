namespace FootballTournamentSystem.Person.Application.Features.President.Commands.Create
{
    using System;

    public class CreatePresidentOutputModel
    {
        public CreatePresidentOutputModel(int presidentId)
        {
            this.PresidentId = presidentId;
        }

        public int PresidentId { get; }
    }
}
