using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Ado_Task_4;

internal class CarContext:DbContext
{
    public DbSet<Car> cars { get; set; }

    public CarContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder();

        builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        var configuration = builder.Build();

        var cons = configuration["ConnectionString"];
        optionsBuilder.UseSqlServer(cons!);
    }
}
