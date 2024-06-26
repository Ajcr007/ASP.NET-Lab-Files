using ActionSelector_core_mvc.controllers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.UseRouting();
app.UseAuthorization();
//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Edit}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Delete}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Update}");

app.Run();