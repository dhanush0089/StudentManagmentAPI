namespace StudentManagementAPI.Middleware
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("Request received: " + context.Request.Path);

            await _next(context);

            Console.WriteLine("Response sent");
        }
    }
}