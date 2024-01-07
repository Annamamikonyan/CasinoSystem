using Microsoft.AspNetCore.Mvc;

namespace Casino.API.Middlewares
{
    public class GlobalExceptionHandlingMiddeleware
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionHandlingMiddeleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception)
            {
                // log some information here 

                var problemDetails = new ProblemDetails
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Title = "Server Error"
                };

                context.Response.StatusCode =
                    StatusCodes.Status500InternalServerError;

                await context.Response.WriteAsJsonAsync(problemDetails);
            }

        }
    }
}
