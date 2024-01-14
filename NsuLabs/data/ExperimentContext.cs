using Microsoft.EntityFrameworkCore;

namespace NsuLabs.data;

public class ExperimentContext : DbContext
{
    public DbSet<ExperimentCondition> ExperimentConditions { get; set; } = null!;
    private String DbPath = "experiments.db";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}
