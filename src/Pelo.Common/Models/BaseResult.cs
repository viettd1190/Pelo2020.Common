using System;
using System.Threading.Tasks;

namespace Pelo.Common.Models
{
    public class BaseResult
    {
        /// <summary>
        ///     Ok
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        protected Task<TResponse<T>> Ok<T>(T data,
                                           string message = "")
        {
            return Task.FromResult(new TResponse<T>(data,
                                                    true,
                                                    message));
        }

        /// <summary>
        ///     Ok
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        protected Task<TResponse<T>> Ok<T>(TResponse<T> data)
        {
            return Task.FromResult(data);
        }

        /// <summary>
        ///     Exception
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ex"></param>
        /// <returns></returns>
        protected Task<TResponse<T>> Exception<T>(Exception ex)
        {
            var res = new TResponse<T>(default(T),
                                       false,
                                       ex.ToString());
            return Task.FromResult(res);
        }

        /// <summary>
        ///     Fail
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message"></param>
        /// <returns></returns>
        protected Task<TResponse<T>> Fail<T>(string message)
        {
            var res = new TResponse<T>(default(T),
                                       false,
                                       message);
            return Task.FromResult(res);
        }
    }
}
