using Microsoft.EntityFrameworkCore;

namespace K8S.Gateway;

public static class SeedData
{
    public static async Task DatabaseMigrator(this ApplicationDbContext dbContext)
    {
        await dbContext.Database.MigrateAsync();
       
    } 
}