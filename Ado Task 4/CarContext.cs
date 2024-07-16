using Microsoft.EntityFrameworkCore;

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
        optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB;Integrated Security = SSPI; Database = Cars;");
    }
}
