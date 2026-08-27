namespace warehouse_telemetry.Infrastructure.Persistence;

using Microsoft.EntityFrameworkCore;
using warehouse_telemetry.Features.Device;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Device> Devices { get; set; }
}
