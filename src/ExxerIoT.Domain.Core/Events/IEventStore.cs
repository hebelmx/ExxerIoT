using NetDevPack.Messaging;

namespace ExxerIoT.Domain.Core.Events
{
    public interface IEventStore
    {
        void Save<T>(T theEvent) where T : Event;
    }
}