using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RestApi.Data; // Add this if AppDbContext is in RestApi.Data namespace

namespace RestApi.Data;

public class dbFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var basePath = Directory.GetCurrentDirectory();

        var config = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json", optional: true)               // usa tu cadena si existe
            .AddJsonFile("appsettings.Development.json", optional: true)   // opcional
            .AddEnvironmentVariables()
            .Build();

        var conn = config.GetConnectionString("DefaultConnection")
                   ?? "Server=tcp:testdavidrobles.database.windows.net,1433;Initial Catalog=SQL_TEST_2025;Persist Security Info=False;User ID=administrador;Password=Socios2024@@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(conn)
            .Options;

        return new AppDbContext(options);
    }
}
