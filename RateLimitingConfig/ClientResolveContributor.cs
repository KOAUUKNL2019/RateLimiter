using AspNetCoreRateLimit;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RateLimiter.RateLimitingConfig
{
    public class ClientResolveContributor : IClientResolveContributor
    {
        public Task<string> ResolveClientAsync(HttpContext httpContext)
        {
            var name = string.Empty;

            if (httpContext.Request.Headers.TryGetValue("UserId", out var values))
            {
                name = values.First();
            }

            return Task.FromResult(name);
        }
    }
}
