using Microsoft.EntityFrameworkCore;

namespace owned_entity_long_name_issue;
public class DataContext : DbContext
{
    public virtual DbSet<AReallyReallyReallyReallyReallyReallyReallyReallyReallyLongOwnerEntity> Owners { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("a"); // no actual connection string required
    }
}