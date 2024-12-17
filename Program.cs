using ASPNET;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/about", () =>
{
    string about = File.ReadAllText("Resources/About.json");
    return JsonSerializer.Deserialize<About>(about);
});

app.MapGet("/rules", () =>
{
    string rules = File.ReadAllText("Resources/Rules.json");
    return JsonSerializer.Deserialize<List<Rules>>(rules);
});

app.Run();
