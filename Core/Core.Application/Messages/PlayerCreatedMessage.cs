namespace Core.Application.Messages
{
    using System;

    public class PlayerCreatedMessage
    {
        public Guid PlayerId { get; set; }

        public int TeamId { get; set; }
    }
}
