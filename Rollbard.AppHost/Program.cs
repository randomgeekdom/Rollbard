var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.Rollbard_ApiService>("apiservice");

builder.AddProject<Projects.Rollbard_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();