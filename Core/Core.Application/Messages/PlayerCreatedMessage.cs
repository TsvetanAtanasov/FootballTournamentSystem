namespace Core.Application.Messages
{
    using System;

    public class PlayerCreatedMessage
    {
        public Guid PlayerGuid { get; set; }

        public int TeamId { get; set; }
    }
}
