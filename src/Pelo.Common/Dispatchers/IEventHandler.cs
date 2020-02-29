using System.Threading.Tasks;
using Pelo.Common.Events;
using Pelo.Common.Kafka;

namespace Pelo.Common.Dispatchers
{
    public interface IEventHandler<in TEvent>
            where TEvent : IEvent
    {
        Task HandleAsync(TEvent @event,
                         ICorrelationContext context);
    }
}
