using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Pelo.Common.Models;

namespace Pelo.Common.Repositories
{
    /// <summary>
    ///     IDapperReadOnlyRepository
    /// </summary>
    public interface IDapperReadOnlyRepository : IDisposable
    {
        /// <summary>
        ///     QueryFirstOrDefaultAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<TResponse<T>> QueryFirstOrDefaultAsync<T>(string sql,
            object data);

        /// <summary>
        ///     QueryAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<TResponse<IEnumerable<T>>> QueryAsync<T>(string sql,
            object data = null);

        Task<TResponse<IEnumerable<T>>> Query<T>(string sql,
            object data = null);

        Task<TResponse<(T1, T2)>> QueryMultipleFFAsync<T1, T2>(string sql,
            object data);

        Task<TResponse<(T1, IEnumerable<T2>)>> QueryMultipleFLAsync<T1, T2>(string sql,
            object data);

        Task<TResponse<(IEnumerable<T1>, T2)>> QueryMultipleLFAsync<T1, T2>(string sql,
            object data);
    }

    /// <summary>
    ///     DapperRepository
    /// </summary>
    public class DapperReadOnlyRepository : BaseRepository,
        IDapperReadOnlyRepository
    {
        /// <summary>
        ///     DapperRepository
        /// </summary>
        /// <param name="connectionString"></param>
        public DapperReadOnlyRepository(string connectionString) : base(connectionString)
        {
        }

        #region IDapperReadOnlyRepository Members

        /// <summary>
        ///     QueryAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<TResponse<IEnumerable<T>>> QueryAsync<T>(string sql,
            object data = null)
        {
            try
            {
                using (var conn = Connection)
                {
                    conn.Open();

                    IEnumerable<T> response;

                    using (var tran = conn.BeginTransaction())
                    {
                        response = await conn.QueryAsync<T>(sql, data, tran);

                        tran.Commit();
                    }

                    conn.Close();

                    return await Ok(response);
                }
            }
            catch (Exception ex)
            {
                return await Fail<IEnumerable<T>>(ex);
            }
        }

        public async Task<TResponse<IEnumerable<T>>> Query<T>(string sql,
            object data = null)
        {
            try
            {
                using (var conn = Connection)
                {
                    conn.Open();

                    IEnumerable<T> response;

                    using (var tran = conn.BeginTransaction())
                    {
                        response = conn.Query<T>(sql, data, tran);

                        tran.Commit();
                    }

                    conn.Close();

                    return await Ok(response);
                }
            }
            catch (Exception ex)
            {
                return await Fail<IEnumerable<T>>(ex);
            }
        }

        /// <summary>
        ///     QueryFirstOrDefaultAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<TResponse<T>> QueryFirstOrDefaultAsync<T>(string sql,
            object data)
        {
            try
            {
                using (var conn = Connection)
                {
                    conn.Open();

                    var response = await conn.QueryFirstOrDefaultAsync<T>(sql, data);

                    conn.Close();

                    return await Ok(response);
                }
            }
            catch (Exception ex)
            {
                return await Fail<T>(ex);
            }
        }

        public async Task<TResponse<(T1, T2)>> QueryMultipleFFAsync<T1, T2>(string sql,
            object data)
        {
            try
            {
                var response = new TResponse<(T1, T2)>();

                using (var conn = Connection)
                {
                    conn.Open();

                    using (var multi = await conn.QueryMultipleAsync(sql, data))
                    {
                        response.Data = (await multi.ReadFirstOrDefaultAsync<T1>(),
                            await multi.ReadFirstOrDefaultAsync<T2>());
                        response.IsSuccess = true;
                    }

                    conn.Close();

                    return await Ok(response);
                }
            }
            catch (Exception ex)
            {
                return await Fail<(T1, T2)>(ex);
            }
        }

        public async Task<TResponse<(T1, IEnumerable<T2>)>> QueryMultipleFLAsync<T1, T2>(string sql,
            object data)
        {
            try
            {
                var response = new TResponse<(T1, IEnumerable<T2>)>();
                using (var conn = Connection)
                {
                    conn.Open();

                    using (var multi = await conn.QueryMultipleAsync(sql, data))
                    {
                        response.Data = ((await multi.ReadAsync<T1>()).FirstOrDefault(), await multi.ReadAsync<T2>());
                        response.IsSuccess = true;
                    }

                    conn.Close();

                    return await Ok(response);
                }
            }
            catch (Exception ex)
            {
                return await Fail<(T1, IEnumerable<T2>)>(ex);
            }
        }

        public async Task<TResponse<(IEnumerable<T1>, T2)>> QueryMultipleLFAsync<T1, T2>(string sql,
            object data)
        {
            try
            {
                var response = new TResponse<(IEnumerable<T1>, T2)>();
                using (var conn = Connection)
                {
                    conn.Open();

                    using (var multi = await conn.QueryMultipleAsync(sql, data))
                    {
                        var t1 = await multi.ReadAsync<T1>();
                        var t2 = (await multi.ReadAsync<T2>()).FirstOrDefault();

                        response.Data = (t1, t2);
                        response.IsSuccess = true;
                    }

                    conn.Close();

                    return await Ok(response);
                }
            }
            catch (Exception ex)
            {
                return await Fail<(IEnumerable<T1>, T2)>(ex);
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
        ~DapperReadOnlyRepository()
        {
            Dispose(false);
        }

        #endregion
    }
}