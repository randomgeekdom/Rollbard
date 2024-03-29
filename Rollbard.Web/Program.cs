using Rollbard.Web;
using Rollbard.Web.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

foreach (var service in Rollbard.Library.RegistrationDictionary.Get())
{
    builder.Services.AddTransient(service.Key, service.Value);
}

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient<WeatherApiClient>(client => client.BaseAddress = new("http://apiservice"));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();