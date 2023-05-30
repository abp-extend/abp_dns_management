using System;
using Microsoft.Extensions.Options;
using CloudFlare.Client;
using CloudFlare.Client.Api.Zones.DnsRecord;
using CloudFlare.Client.Api.Result;

namespace Sajan.DnsManagement.Cloudflare
{
	public class DnsManagementService
	{
		private readonly IOptions<DnsManagementOptions> _options;
		private readonly CloudFlareClient _cloudFlareClient; 
		public DnsManagementService(IOptions<DnsManagementOptions> options)
		{
			_options = options;
			_cloudFlareClient = new CloudFlareClient(options.Value.Token);
		}

		public async Task<CloudFlareResult<DnsRecord>> CreateCnameRecordAsync(NewDnsRecordBase newDnsRecord)
		{
			var zoneId = _options.Value.ZoneId;
			return await _cloudFlareClient.Zones.DnsRecords.AddAsync(zoneId, newDnsRecord);
		}
	}
}

