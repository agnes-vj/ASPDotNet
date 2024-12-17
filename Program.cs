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

app.MapPost("/rules", (Rules input) =>
{
    string filePath = "Resources/Rules.json";

    List<Rules> rules = JsonSerializer.Deserialize<List<Rules>>(File.ReadAllText(filePath));
    int newId = rules.Count + 1 ;
    input.Id = newId;
    rules.Add(input);
    
    File.WriteAllText("Resources/Rules.json",JsonSerializer.Serialize(rules));
    return input;
});

app.MapGet("/rules/{id}", (int id) =>
{
    string filePath = "Resources/Rules.json";
    List<Rules> rules = JsonSerializer.Deserialize<List<Rules>>(File.ReadAllText(filePath));
    //Rules rule = rules.FirstOrDefault(r => r.Id == id);
    return JsonSerializer.Serialize<List<Rules>>(rules.FindAll(r => r.Id == id));
});

app.Run();
