namespace FootballTournamentSystem.Person.Application.Features.Player.Commands.Create
{
    using System;

    public class CreatePlayerOutputModel
    {
        public CreatePlayerOutputModel(int playerId)
        {
            this.PlayerId = playerId;
        }

        public int PlayerId { get; }
    }
}
