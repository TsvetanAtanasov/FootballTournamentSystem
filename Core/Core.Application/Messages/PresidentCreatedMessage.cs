namespace Core.Application.Messages
{
    using System;

    public class PresidentCreatedMessage
    {
        public Guid PresidentId { get; set; }

        public int TeamId { get; set; }
    }
}
