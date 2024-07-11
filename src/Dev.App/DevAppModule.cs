using Dev.Core;
using Volo.Abp.Modularity;

namespace Dev.App;

[DependsOn(typeof(DevCoreModule))]
public class DevAppModule: AbpModule
{
}