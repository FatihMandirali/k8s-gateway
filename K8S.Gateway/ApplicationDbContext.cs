using Microsoft.EntityFrameworkCore;

namespace K8S.Gateway;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<SampleData> SampleData { get; set; }
}