using AspNetCoreRateLimit;
using Microsoft.Extensions.Options;

namespace RateLimiter.RateLimitingConfig
{
    public class RateLimitingConfig : RateLimitConfiguration
    {
        public RateLimitingConfig(IOptions<IpRateLimitOptions> ipOptions, IOptions<ClientRateLimitOptions> clientOptions) : base(ipOptions, clientOptions)
        {
        }

        public override void RegisterResolvers()
        {
            base.RegisterResolvers();
            ClientResolvers.Add(new ClientResolveContributor());
        }
    }
}
