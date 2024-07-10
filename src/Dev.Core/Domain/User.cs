using Volo.Abp.Domain.Entities;

namespace Dev.Core.Domain;

public class User: Entity<long>
{
    public User()
    {

    }

    public string Name { get; set; }
}