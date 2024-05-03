var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Bookstore}/{action=Index}");

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Bookstore}/{action=Aboutus}");

app.Run();
