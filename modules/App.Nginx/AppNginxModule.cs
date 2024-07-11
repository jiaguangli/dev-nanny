using Dev.Core;
using Volo.Abp.Modularity;

namespace App.Nginx;


[DependsOn(typeof(DevCoreModule))]
public class AppNginxModule: AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
    }
}