using System;

namespace FootballTournamentSystem.Application.Features.Person.Player.Commands.Create
{
    public class CreatePlayerOutputModel
    {
        public CreatePlayerOutputModel(Guid playerId)
        {
            this.PlayerId = playerId;
        }

        public Guid PlayerId { get; }
    }
}
