var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Web>("webServer");

builder.AddProject<Projects.WindowsUI>("windowsClient");

builder.Build().Run();
