using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LibraryManagementSystem.Repository
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();

            // var connectionString = $"Server={server};Database={database};User Id={userId};Password={password};";
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            builder.UseSqlServer(connectionString);
            return new AppDbContext(builder.Options);
        }

    }
}
