using System;

namespace Common.Domain.Events
{
    public class PresidentCreatedEvent : IDomainEvent
    {
        public PresidentCreatedEvent(Guid presidentId, int teamId)
        {
            this.PresidentId = presidentId;
            this.TeamId = teamId;
        }

        public Guid PresidentId { get; }

        public int TeamId { get; }
    }
}

