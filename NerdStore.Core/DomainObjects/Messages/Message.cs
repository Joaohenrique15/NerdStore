using System;

namespace NerdStore.Core.DomainObjects.Messages
{
    public abstract class Message
    {
        public Message()
        {
            MessageType = GetType().Name;
        }

        public string MessageType { get; protected set; }
        public Guid AggregateId { get; protected set; }
    }
}
