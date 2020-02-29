using System.Threading.Tasks;
using Pelo.Common.Events;

namespace Pelo.Common.Dispatchers
{
    public class Dispatcher : IDispatcher
    {
        private readonly IEventDispatcher _eventDispatcher;

        public Dispatcher(IEventDispatcher eventDispatcher)
        {
            _eventDispatcher = eventDispatcher;
        }

        #region IDispatcher Members

        public async Task SendEventAsync<TEvent>(TEvent @event)
                where TEvent : IEvent =>
                await _eventDispatcher.SendEventAsync(@event);

        #endregion
    }
}
