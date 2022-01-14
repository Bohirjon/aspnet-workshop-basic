namespace AspNet.BasicsDemo;

public static class Program
{
    private static void Main(string[] args)
    {
        var host = CreateHostBuilder(args)
            .Build();
        using var scope = host.Services.CreateScope();
        var services = scope.ServiceProvider;
        
        //ensuring db created
        var context = services.GetRequiredService<AppDbContext>();
        context.Database.EnsureCreated();

        host.Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup(typeof(Startup)); });
}