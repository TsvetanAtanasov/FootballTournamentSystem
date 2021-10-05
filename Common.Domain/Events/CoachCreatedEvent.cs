namespace Common.Domain.Events
{
    using System;

    public class CoachCreatedEvent : IDomainEvent
    {
        public CoachCreatedEvent(Guid coachId, int teamId)
        {
            this.CoachId = coachId;
            this.TeamId = teamId;
        }

        public Guid CoachId { get; }

        public int TeamId { get; }
    }
}

