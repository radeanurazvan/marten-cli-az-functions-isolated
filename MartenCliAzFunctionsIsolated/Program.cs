using Marten;
using Microsoft.Extensions.Hosting;
using Oakton;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(s => s.AddMarten("host=localhost;password=postgres;username=postgres;Database=postgres"))
    .ApplyOaktonExtensions()
    .Build();

await host.RunOaktonCommands(args);
