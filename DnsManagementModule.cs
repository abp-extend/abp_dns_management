using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace Sajan.DnsManagement.Cloudflare;

public class DnsManagementModule: AbpModule
{
    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        context.ServiceProvider.GetService<DnsManagementService>();
    }
}

