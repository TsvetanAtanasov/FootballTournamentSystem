namespace Core.Application.Messages
{
    using System;

    public class PresidentCreatedMessage
    {
        public Guid PresidentGuid { get; set; }

        public int TeamId { get; set; }
    }
}
