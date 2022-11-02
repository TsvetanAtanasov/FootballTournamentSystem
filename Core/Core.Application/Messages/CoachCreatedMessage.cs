namespace Core.Application.Messages
{
    using System;

    public class CoachCreatedMessage
    {
        public int TeamId { get; set; }

        public Guid CoachGuid { get; set; }
    }
}
