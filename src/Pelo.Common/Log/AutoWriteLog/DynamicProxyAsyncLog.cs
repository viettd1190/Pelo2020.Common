using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Microsoft.Extensions.Configuration;
using Pelo.Common.Exceptions;
using Pelo.Common.Extensions;
using Pelo.Common.Log.Extensions;
using Pelo.Common.Log.Logs;
using Pelo.Common.Log.Utils;
using Pelo.Common.Models;

namespace Pelo.Common.Log.AutoWriteLog
{
    public class DynamicProxyAsyncLog : IAsyncInterceptor
    {
        private readonly IConfiguration _configuration;

        public DynamicProxyAsyncLog(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        #region IAsyncInterceptor Members

        public void InterceptSynchronous(IInvocation invocation)
        {
            var serverIp = LogUtils.GetLocalIPAddress(AddressFamily.InterNetwork); // "192.168.1.1";
            var logType = LogTypes.None;
            var message = string.Empty;
            var throwException = false;

            var watch = Stopwatch.StartNew();

            try
            {
                invocation.Proceed(); //Intercepted method is executed here.
            }
            catch (PeloException ex)
            {
                throwException = true;
                logType = LogTypes.Exception;
                message = ex.Message;
            }
            catch (Exception ex)
            {
                throwException = true;
                logType = LogTypes.Exception;
                message = ex.Message;
            }
            finally
            {
                watch.Stop();
            }

            if(invocation.ReturnValue is TResponse<object> returnObj)
            {
                logType = LogTypes.Trace;
                message = returnObj.Message;
            }
            else
            {
                if(logType == LogTypes.None)
                {
                    logType = LogTypes.Trace;
                }
            }

            var logDetails = new LogDetails
                             {
                                     Data = new Data
                                            {
                                                    Parameters = invocation.Arguments,
                                                    ReturnValue = invocation.ReturnValue
                                            },
                                     Location = new Location
                                                {
                                                        Function = invocation.Method.Name,
                                                        ClassName = invocation.TargetType.Name,
                                                        Namespace = invocation.TargetType.Namespace
                                                },
                                     Identity = TimeUUID.Next(),
                                     LogType = logType,
                                     Message = message,
                                     Server = serverIp,
                                     TransactionId = string.Empty,
                                     Client = LogUtils.GetClientIP(),
                                     Elapsed = watch.ElapsedMilliseconds,
                                     ExecDate = DateTime.Now
                             };

            if(logDetails.LogType == LogTypes.Exception)
            {
                SerilogHelper.GetInstance(_configuration)
                             .Error(logDetails.ToJson());
            }
            else
            {
                SerilogHelper.GetInstance(_configuration)
                             .Debug(logDetails.ToJson());
            }

            if(throwException)
            {
                throw new PeloException(message);
            }
        }

        public void InterceptAsynchronous(IInvocation invocation)
        {
            invocation.ReturnValue = InternalInterceptAsynchronous(invocation);
        }

        public void InterceptAsynchronous<TResult>(IInvocation invocation)
        {
            invocation.ReturnValue = InternalInterceptAsynchronous<TResult>(invocation);
        }

        #endregion

        private async Task InternalInterceptAsynchronous(IInvocation invocation)
        {
            var serverIp = LogUtils.GetLocalIPAddress(AddressFamily.InterNetwork); // "192.168.1.1";
            var logType = LogTypes.None;
            var message = string.Empty;
            var throwException = false;

            var watch = Stopwatch.StartNew();

            try
            {
                invocation.Proceed();
                var task = (Task) invocation.ReturnValue;
                await task;
            }
            catch (PeloException ex)
            {
                throwException = true;
                logType = LogTypes.Exception;
                message = ex.Message;
            }
            catch (Exception ex)
            {
                throwException = true;
                logType = LogTypes.Exception;
                message = ex.Message;
            }
            finally
            {
                watch.Stop();
            }

            if(logType == LogTypes.None)
            {
                logType = LogTypes.Trace;
            }

            var logDetails = new LogDetails
                             {
                                     Data = new Data
                                            {
                                                    Parameters = invocation.Arguments,
                                                    ReturnValue = string.Empty
                                            },
                                     Location = new Location
                                                {
                                                        Function = invocation.Method.Name,
                                                        ClassName = invocation.TargetType.Name,
                                                        Namespace = invocation.TargetType.Namespace
                                                },
                                     Identity = TimeUUID.Next(),
                                     LogType = logType,
                                     Message = message,
                                     Server = serverIp,
                                     TransactionId = string.Empty,
                                     Client = LogUtils.GetClientIP(),
                                     Elapsed = watch.ElapsedMilliseconds,
                                     ExecDate = DateTime.Now
                             };
            if(logDetails.LogType == LogTypes.Exception)
            {
                SerilogHelper.GetInstance(_configuration)
                             .Error(logDetails.ToJson());
            }
            else
            {
                SerilogHelper.GetInstance(_configuration)
                             .Debug(logDetails.ToJson());
            }

            if(throwException)
            {
                throw new PeloException(message);
            }
        }

        private async Task<TResult> InternalInterceptAsynchronous<TResult>(IInvocation invocation)
        {
            var serverIp = LogUtils.GetLocalIPAddress(AddressFamily.InterNetwork);
            var logType = LogTypes.None;
            var message = string.Empty;
            var throwException = false;
            TResult result = default(TResult);

            var watch = Stopwatch.StartNew();

            try
            {
                invocation.Proceed();
                var task = (Task<TResult>) invocation.ReturnValue;
                result = await task;
            }
            catch (PeloException ex)
            {
                throwException = true;
                logType = LogTypes.Exception;
                message = ex.Message;
            }
            catch (Exception ex)
            {
                throwException = true;
                logType = LogTypes.Exception;
                message = ex.Message;
            }
            finally
            {
                watch.Stop();
            }

            var returnObj = result as TResponse<object>;

            if(returnObj != null)
            {
                logType = LogTypes.Trace;
                message = returnObj.Message;
            }
            else
            {
                if(logType == LogTypes.None)
                {
                    logType = LogTypes.Trace;
                }
            }

            var logDetails = new LogDetails
                             {
                                     Data = new Data
                                            {
                                                    Parameters = invocation.Arguments,
                                                    ReturnValue = result
                                            },
                                     Location = new Location
                                                {
                                                        Function = invocation.Method.Name,
                                                        ClassName = invocation.TargetType.Name,
                                                        Namespace = invocation.TargetType.Namespace
                                                },
                                     Identity = TimeUUID.Next(),
                                     LogType = logType,
                                     Message = message,
                                     Server = serverIp,
                                     TransactionId = string.Empty,
                                     Client = LogUtils.GetClientIP(),
                                     Elapsed = watch.ElapsedMilliseconds,
                                     ExecDate = DateTime.Now
                             };

            if(logDetails.LogType == LogTypes.Exception)
            {
                SerilogHelper.GetInstance(_configuration)
                             .Error(logDetails.ToJson());
            }
            else
            {
                SerilogHelper.GetInstance(_configuration)
                             .Debug(logDetails.ToJson());
            }

            if(!throwException)
            {
                return result;
            }

            throw new PeloException(message);
        }
    }
}
