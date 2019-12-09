using System;
using System.Threading.Tasks;
using Dapper;
using Pelo.Common.Models;

namespace Pelo.Common.Repositories
{
    /// <summary>
    ///     IDapperWriteRepository
    /// </summary>
    public interface IDapperWriteRepository : IDisposable
    {
        /// <summary>
        ///     ExecuteAsync
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<TResponse<int>> ExecuteAsync(string sql,
            object data);

        /// <summary>
        ///     ExecuteScalarAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<TResponse<T>> ExecuteScalarAsync<T>(string sql,
            object data);
    }

    /// <summary>
    ///     DapperRepository
    /// </summary>
    public class DapperWriteRepository : BaseRepository,
        IDapperWriteRepository
    {
        /// <summary>
        ///     DapperRepository
        /// </summary>
        /// <param name="connectionString"></param>
        public DapperWriteRepository(string connectionString) : base(connectionString)
        {
        }

        #region IDapperWriteRepository Members

        /// <summary>
        ///     ExecuteAsync
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<TResponse<int>> ExecuteAsync(string sql,
            object data)
        {
            try
            {
                using (var conn = Connection)
                {
                    conn.Open();
                    var response = 0;
                    using (var tran = conn.BeginTransaction())
                    {
                        response = await conn.ExecuteAsync(sql, data, tran);

                        tran.Commit();
                    }

                    conn.Close();

                    return await Ok(response);
                }
            }
            catch (Exception ex)
            {
                return await Fail<int>(ex);
            }
        }

        /// <summary>
        ///     ExecuteScalarAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<TResponse<T>> ExecuteScalarAsync<T>(string sql,
            object data)
        {
            try
            {
                using (var conn = Connection)
                {
                    conn.Open();
                    T response;
                    using (var tran = conn.BeginTransaction())
                    {
                        response = await conn.ExecuteScalarAsync<T>(sql, data, tran);

                        tran.Commit();
                    }

                    conn.Close();

                    return await Ok(response);
                }
            }
            catch (Exception ex)
            {
                return await Fail<T>(ex);
            }
        }

        #endregion

        #region Dispose

        // Flag: Has Dispose already been called?
        private bool _disposed;

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
                //_db.Dispose();
            }

            // Free any unmanaged objects here.
            //
            _disposed = true;
        }

        /// <summary>
        ///     Distroy
        /// </summary>
        ~DapperWriteRepository()
        {
            Dispose(false);
        }

        #endregion
    }
}