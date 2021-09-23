namespace Common.Domain.Events
{
    public class PresidentCreatedEvent : IDomainEvent
    {
        public PresidentCreatedEvent(int presidentId, int teamId)
        {
            this.PresidentId = presidentId;
            this.TeamId = teamId;
        }

        public int PresidentId { get; }

        public int TeamId { get; }
    }
}

