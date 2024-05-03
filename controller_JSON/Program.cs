using controller_JSON.Controllers_JSON;
using controller_JSON.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllers();
app.Run();

 