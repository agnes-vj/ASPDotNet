using ASPNET;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ASPDbContext>(options => options.UseSqlServer(connectionString));
var app = builder.Build();

//app.MapGet("/about", () =>
//{
//    string about = File.ReadAllText("Resources/About.json");
//    return JsonSerializer.Deserialize<About>(about);
//});
app.MapGet("/about", (ASPDbContext db) =>
{
    var abouts = db.About;
    return abouts;
});

//app.MapGet("/rules", () =>
//{
//    string rules = File.ReadAllText("Resources/Rules.json");
//    return JsonSerializer.Deserialize<List<Rules>>(rules);
//});

app.MapGet("/rules", (ASPDbContext db) =>
{    
    return db.Rules;
});

//app.MapPost("/rules", (Rules input) =>
//{
//    string filePath = "Resources/Rules.json";

//    List<Rules> rules = JsonSerializer.Deserialize<List<Rules>>(File.ReadAllText(filePath));
//    int newId = rules.Count + 1 ;
//    input.Id = newId;
//    rules.Add(input);

//    File.WriteAllText("Resources/Rules.json",JsonSerializer.Serialize(rules));
//    return input;
//});

app.MapPost("/Shops", (Shops input, ASPDbContext db) =>
{
    db.Shops.Add(input);
    db.SaveChanges();
    return input;
});

//app.MapGet("/rules/{id}", (int id) =>
//{
//    string filePath = "Resources/Rules.json";
//    List<Rules> rules = JsonSerializer.Deserialize<List<Rules>>(File.ReadAllText(filePath));
//    //Rules rule = rules.FirstOrDefault(r => r.Id == id);
//    return JsonSerializer.Serialize<List<Rules>>(rules.FindAll(r => r.Id == id));
//});

app.MapGet("/rules/{id}", (int id, ASPDbContext db) =>
{
    return db.Rules.Where(r => r.Id == id);
});

//app.MapDelete("rules/{id}", (int id) =>
//{
//    string filePath = "Resources/Rules.json";
//    List<Rules> rules = JsonSerializer.Deserialize<List<Rules>>(File.ReadAllText(filePath));
//    rules.Remove(rules.Find(r => r.Id == id));
//    File.WriteAllText("Resources/Rules.json", JsonSerializer.Serialize(rules));
//    return Results.NoContent();
//});

app.MapDelete("rules/{id}", (int id, ASPDbContext db) =>
{
    db.Rules.Remove(db.Rules.FirstOrDefault(r => r.Id == id));
    db.SaveChanges();
    return Results.NoContent();
});

//app.MapPatch("rules/{id}", (int id, string content) =>
//{
//    string filePath = "Resources/Rules.json";
//    List<Rules> rules = JsonSerializer.Deserialize<List<Rules>>(File.ReadAllText(filePath));
//    Rules rule = rules.FirstOrDefault(r => r.Id == id);
//    rule.Description = content;
//    File.WriteAllText("Resources/Rules.json", JsonSerializer.Serialize(rules));
//    return Results.Ok(rule);
//});

app.MapPatch("rules/{id}", (int id, string content, ASPDbContext db) =>
{
    db.Rules.FirstOrDefault(r => r.Id == id).Description = content;
    db.SaveChanges();
    return Results.Ok(db.Rules.FirstOrDefault(r => r.Id == id));
});

//app.MapGet("/treasure/{id}", (int id) =>
//{
//    string filePath = "Resources/Treasures.json";
//    List<Treasure> treasure = JsonSerializer.Deserialize<List<Treasure>>(File.ReadAllText(filePath));
//    //Rules rule = rules.FirstOrDefault(r => r.Id == id);
//    return JsonSerializer.Serialize<List<Treasure>>(treasure.FindAll(r => r.Id == id));
//});

app.MapGet("/treasure/{id}", (int id, ASPDbContext db) =>
{
    return db.Treasures.FirstOrDefault(t => t.Id == id);
});

//app.MapPost("/shops", (Shops input) =>
//{
//    string filePath = "Resources/Shops.json";

//    List<Shops> shops = JsonSerializer.Deserialize<List<Shops>>(File.ReadAllText(filePath));
//    int newId = shops.Count + 1;
//    input.Id = newId;
//    shops.Add(input);

//    File.WriteAllText(filePath, JsonSerializer.Serialize(shops));
//    return input;
//});
app.MapGet("/Shops", (ASPDbContext db) =>
{
    return db.Shops;
});

app.Run();
