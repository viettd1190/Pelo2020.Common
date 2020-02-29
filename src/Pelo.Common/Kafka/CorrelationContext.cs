using System;
using Newtonsoft.Json;
using Pelo.Common.Extensions;

namespace Pelo.Common.Kafka
{
    public interface ICorrelationContext
    {
        Guid Id { get; }

        Guid UserId { get; }

        Guid ResourceId { get; }

        string TraceId { get; }

        string SpanContext { get; }

        string ConnectionId { get; }

        string Name { get; }

        string Origin { get; }

        string Resource { get; }

        string Culture { get; }

        DateTime CreatedAt { get; }

        int Retries { get; set; }
    }

    public class CorrelationContext : ICorrelationContext
    {
        public CorrelationContext()
        {
        }

        private CorrelationContext(Guid id)
        {
            Id = id;
        }

        [JsonConstructor]
        private CorrelationContext(Guid id,
                                   Guid userId,
                                   Guid resourceId,
                                   string traceId,
                                   string spanContext,
                                   string connectionId,
                                   string executionId,
                                   string name,
                                   string origin,
                                   string culture,
                                   string resource,
                                   int retries)
        {
            Id = id;
            UserId = userId;
            ResourceId = resourceId;
            TraceId = traceId;
            SpanContext = spanContext;
            ConnectionId = connectionId;
            Name = string.IsNullOrWhiteSpace(name)
                           ? string.Empty
                           : GetName(name);
            Origin = string.IsNullOrWhiteSpace(origin) ? string.Empty :
                     origin.StartsWith("/") ? origin.Remove(0,
                                                            1) : origin;
            Culture = culture;
            Resource = resource;
            Retries = retries;
            CreatedAt = DateTime.UtcNow;
        }

        public static ICorrelationContext Empty => new CorrelationContext();

        #region ICorrelationContext Members

        public Guid Id { get; }

        public Guid UserId { get; }

        public Guid ResourceId { get; }

        public string TraceId { get; }

        public string SpanContext { get; }

        public string ConnectionId { get; }

        public string Name { get; }

        public string Origin { get; }

        public string Resource { get; }

        public string Culture { get; }

        public int Retries { get; set; }

        public DateTime CreatedAt { get; }

        #endregion

        public static ICorrelationContext FromId(Guid id) => new CorrelationContext(id);

        public static ICorrelationContext From<T>(ICorrelationContext context) =>
                Create<T>(context.Id,
                          context.UserId,
                          context.ResourceId,
                          context.TraceId,
                          context.ConnectionId,
                          context.Origin,
                          context.Culture,
                          context.Resource);

        public static ICorrelationContext Create<T>(Guid id,
                                                    Guid userId,
                                                    Guid resourceId,
                                                    string origin,
                                                    string traceId,
                                                    string spanContext,
                                                    string connectionId,
                                                    string culture,
                                                    string resource = "") =>
                new CorrelationContext(id,
                                       userId,
                                       resourceId,
                                       traceId,
                                       spanContext,
                                       connectionId,
                                       string.Empty,
                                       typeof(T).Name,
                                       origin,
                                       culture,
                                       resource,
                                       0);

        private static string GetName(string name) =>
                name.Underscore()
                    .ToLowerInvariant();
    }
}
