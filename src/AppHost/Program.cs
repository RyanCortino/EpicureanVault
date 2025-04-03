var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

builder.AddProject<Projects.Web>("webServer").WithReference(cache);

builder.AddProject<Projects.WindowsUI>("windowsClient");

builder.Build().Run();
