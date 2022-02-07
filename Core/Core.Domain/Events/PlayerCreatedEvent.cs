namespace Core.Domain.Events
{
    using System;

    public class PlayerCreatedEvent : IDomainEvent
    {
        public PlayerCreatedEvent(Guid playerId, int teamId)
        {
            this.PlayerId = playerId;
            this.TeamId = teamId;
        }

        public Guid PlayerId { get; }

        public int TeamId { get; }
    }
}

