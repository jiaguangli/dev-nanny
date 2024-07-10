using Dev.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Dev.Core.Context;

[ConnectionStringName("DevNanny")]
public class DevNannyContext: AbpDbContext<DevNannyContext>
{
    public DbSet<User> Users { get; set; }
    public DevNannyContext(DbContextOptions<DevNannyContext> options) : base(options)
    {

    }
}