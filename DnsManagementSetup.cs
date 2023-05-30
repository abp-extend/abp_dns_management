using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Sajan.DnsManagement.Cloudflare
{
	public class DnsManagementSetup: IConfigureOptions<DnsManagementOptions>
	{
        private const string SectionName = "Cloudflare";

        private readonly IConfiguration _configuration;

		public DnsManagementSetup(IConfiguration configuration)
		{
            _configuration = configuration;
		}

        public void Configure(DnsManagementOptions options)
        {
            _configuration
                .GetSection(SectionName)
                .Bind(options);
        }
    }
}
