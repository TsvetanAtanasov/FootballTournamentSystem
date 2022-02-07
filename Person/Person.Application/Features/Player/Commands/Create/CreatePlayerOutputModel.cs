namespace FootballTournamentSystem.Person.Application.Features.Player.Commands.Create
{
    using System;

    public class CreatePlayerOutputModel
    {
        public CreatePlayerOutputModel(Guid playerId)
        {
            this.PlayerId = playerId;
        }

        public Guid PlayerId { get; }
    }
}
