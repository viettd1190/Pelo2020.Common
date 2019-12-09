using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Pelo.Common.Models;

namespace Pelo.Common.Repositories
{
    public class BaseRepository
    {
        private readonly string _connectionString;

        public BaseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected IDbConnection Connection => new SqlConnection(_connectionString);

        /// <summary>
        ///     Ok
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        protected Task<TResponse<T>> Ok<T>(T data)
        {
            return Task.FromResult(new TResponse<T>
            {
                Data = data,
                IsSuccess = true,
                Message = string.Empty
            });
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
        ///     Fail
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ex"></param>
        /// <returns></returns>
        protected Task<TResponse<T>> Fail<T>(Exception ex)
        {
            return Task.FromResult(new TResponse<T>
            {
                Data = default,
                IsSuccess = false,
                Message = ex.ToString()
            });
        }

        /// <summary>
        ///     Fail
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message"></param>
        /// <returns></returns>
        protected Task<TResponse<T>> Fail<T>(string message)
        {
            return Task.FromResult(new TResponse<T>
            {
                Data = default,
                IsSuccess = false,
                Message = message
            });
        }
    }
}