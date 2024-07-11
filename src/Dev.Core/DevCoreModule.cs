using Dev.Core.Context;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Sqlite;
using Volo.Abp.Modularity;

namespace Dev.Core;
[DependsOn(typeof(AbpEntityFrameworkCoreSqliteModule))]
public class DevCoreModule: AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbContextOptions>(options  =>
        {
            options .Configure<DevNannyContext>(opt =>
            {
                opt.UseSqlite();
            });
        });

        context.Services.AddDbContext<DevNannyContext>();
        base.ConfigureServices(context);
    }
}