public class DatabaseSeeder : IHostedService
{
    private readonly IServiceScopeFactory _scopeFactory;

    public DatabaseSeeder(IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        using var scope = _scopeFactory.CreateScope();

        var deviceSeeder =
            scope.ServiceProvider.GetRequiredService<DeviceSeeder>();

        await deviceSeeder.SeedAsync();
    }

    public Task StopAsync(CancellationToken cancellationToken)
        => Task.CompletedTask;
}
