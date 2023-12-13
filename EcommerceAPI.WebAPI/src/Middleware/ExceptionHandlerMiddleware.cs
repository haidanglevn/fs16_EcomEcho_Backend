
namespace EcommerceAPI.WebAPI.src.Middleware
{
    public class ExceptionHandlerMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception e)
            {
                await context.Response.WriteAsync("Error occurred: ");
            }
        }
    }
}