using System.Threading.Tasks;
using Pelo.Common.Events;

namespace Pelo.Common.Dispatchers
{
    public interface IDispatcher
    {
        Task SendEventAsync<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}
