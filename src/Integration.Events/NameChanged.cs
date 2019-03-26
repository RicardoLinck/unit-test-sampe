using System;

namespace Sample.Integration.Events
{
    public class NameChanged
    {
        public Guid EventId { get; }
        public string Name { get; }

        public NameChanged(Guid eventId, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name can't be empty.", nameof(name));
            }

            EventId = eventId;
            Name = name;
        }
    }
}