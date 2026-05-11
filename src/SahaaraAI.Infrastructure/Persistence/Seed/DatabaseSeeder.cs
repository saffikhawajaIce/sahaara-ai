namespace SahaaraAI.Infrastructure.Persistence.Seed;

public static class DatabaseSeeder
{
    public static async Task SeedAsync(SahaaraDbContext dbContext)
    {
        await RoleSeeder.SeedAsync(dbContext);
        await CategorySeeder.SeedAsync(dbContext);
        await UserSeeder.SeedAsync(dbContext);
        await NgoSeeder.SeedAsync(dbContext);
    }
}
