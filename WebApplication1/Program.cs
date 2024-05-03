using First_Core_App.MyMiddleware;

using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<MyMiddleware>();

var app = builder.Build();

//app.MapGet("/", () => "Ajin K James");

app.Use( async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Header part");
    await next(context);
}
);

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("\n\n\n");
    await next(context);
}
);
app.UseMiddleware<MyMiddleware>();

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Footer part");
}
);
app.Run();
        