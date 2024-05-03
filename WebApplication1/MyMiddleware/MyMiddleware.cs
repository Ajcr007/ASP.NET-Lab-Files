
namespace First_Core_App.MyMiddleware
{
    public class MyMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            //throw new NotImplementedException();

            await context.Response.WriteAsync("\ncontent Part1");
            await context.Response.WriteAsync("\ncontent Part2");
            await next(context);
            await context.Response.WriteAsync("\nMiddleware work is finish....");
        }
    }
}
