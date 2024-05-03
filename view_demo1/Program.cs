
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{action=Index}");

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{action=AboutUs}");

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{action=Contact}");

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Student}/{action=Delete}");

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Student}/{action=Edit}");
app.Run();
