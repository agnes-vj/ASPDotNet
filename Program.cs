using ASPNET;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ASPDbContext>(options => options.UseSqlServer(connectionString));
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

app.MapDelete("rules/{id}", (int id) =>
{
    string filePath = "Resources/Rules.json";
    List<Rules> rules = JsonSerializer.Deserialize<List<Rules>>(File.ReadAllText(filePath));
    rules.Remove(rules.Find(r => r.Id == id));
    File.WriteAllText("Resources/Rules.json", JsonSerializer.Serialize(rules));
    return Results.NoContent();
});

app.MapPatch("rules/{id}", (int id, string content) =>
{
    string filePath = "Resources/Rules.json";
    List<Rules> rules = JsonSerializer.Deserialize<List<Rules>>(File.ReadAllText(filePath));
    Rules rule = rules.FirstOrDefault(r => r.Id == id);
    rule.Description = content;
    File.WriteAllText("Resources/Rules.json", JsonSerializer.Serialize(rules));
    return Results.Ok(rule);
});

app.MapGet("/treasure/{id}", (int id) =>
{
    string filePath = "Resources/Treasures.json";
    List<Treasure> treasure = JsonSerializer.Deserialize<List<Treasure>>(File.ReadAllText(filePath));
    //Rules rule = rules.FirstOrDefault(r => r.Id == id);
    return JsonSerializer.Serialize<List<Treasure>>(treasure.FindAll(r => r.Id == id));
});

app.MapPost("/shops", (Shops input) =>
{
    string filePath = "Resources/Shops.json";

    List<Shops> shops = JsonSerializer.Deserialize<List<Shops>>(File.ReadAllText(filePath));
    int newId = shops.Count + 1;
    input.Id = newId;
    shops.Add(input);

    File.WriteAllText(filePath, JsonSerializer.Serialize(shops));
    return input;
});
app.MapGet("/shops", () =>
{
    string shops = File.ReadAllText("Resources/Shops.json");
    return JsonSerializer.Deserialize<List<Shops>>(shops);
});

app.Run();
