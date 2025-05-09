var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => 
{
    return Results.Ok("Hello World");
});
app.MapGet("/{nome}", (string nome) => 
{
    return Results.Ok($"Hello World {nome}");
});

app.MapPost("/", (User user) => { return Results.Ok("Meu nome e " + user.Username); });

app.Run();
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
}