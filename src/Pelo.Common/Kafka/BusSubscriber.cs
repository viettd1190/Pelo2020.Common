﻿using System;
using System.Threading.Tasks;
using Confluent.Kafka;
using Newtonsoft.Json;
using Pelo.Common.Events;
using Pelo.Common.Models;

namespace Pelo.Common.Kafka
{
    public interface IBusSubscriber : IDisposable
    {
        Task<TResponse<TCommand>> SubscribeCommand<TCommand>(string topicName);

        Task<TResponse<T>> SubscribeEvent<T>()
                where T : IEvent;
    }

    public class BusSubscriber : BaseResult,
                                 IBusSubscriber
    {
        #region Defines

        private readonly IConsumer<Ignore, string> _consumer;

        #endregion

        #region C'tor

        /// <summary>
        ///     C'tor
        /// </summary>
        /// <param name="config"></param>
        public BusSubscriber(ConsumerConfig config)
        {
            _consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        }

        #endregion

        #region IBusSubscriber Members

        public async Task<TResponse<TCommand>> SubscribeCommand<TCommand>(string topicName)
        {
            try
            {
                _consumer.Subscribe(topicName);
                var consumeResult = _consumer.Consume();

                return await Ok(JsonConvert.DeserializeObject<TCommand>(consumeResult.Value));
            }
            catch (Exception ex)
            {
                return await Exception<TCommand>(ex);
            }
        }

        public async Task<TResponse<T>> SubscribeEvent<T>()
                where T : IEvent
        {
            var topicName = typeof(T).FullName;
            try
            {
                _consumer.Subscribe(topicName);
                var consumeResult = _consumer.Consume();

                return await Ok(JsonConvert.DeserializeObject<T>(consumeResult.Value));
            }
            catch (Exception ex)
            {
                return await Exception<T>(ex);
            }
        }

        #endregion

        #region Dispose

        // Flag: Has Dispose already been called?
        bool disposed;

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if(disposed)
                return;

            if(disposing)
            {
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        /// <summary>
        ///     Distroy
        /// </summary>
        ~BusSubscriber()
        {
            Dispose(false);
        }

        #endregion
    }
}
