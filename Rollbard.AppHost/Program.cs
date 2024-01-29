var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("cache");

var apiservice = builder.AddProject<Projects.Rollbard_ApiService>("apiservice");

builder.AddProject<Projects.Rollbard_Web>("webfrontend")
    .WithReference(cache)
    .WithReference(apiservice);

builder.AddProject<Projects.Rollbard_Worldbuilding>("worldbuilding");

builder.Build().Run();
