using System.Threading.Tasks;
using Pelo.Common.Events;

namespace Pelo.Common.Dispatchers
{
    public interface IEventDispatcher
    {
        Task SendEventAsync<T>(T @event) where T : IEvent;
    }
}
