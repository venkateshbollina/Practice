using Microsoft.AspNetCore.Diagnostics;

namespace GlobalExceptionHandling
{
    public class AppExceptionHandler(ILogger<AppExceptionHandler> logger) : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync
            (HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            if (exception is not NotImplementedException )
            {
                logger.LogError(exception, exception.Message);
                var response = new ErrorResponse()
                {
                    statusCode = StatusCodes.Status500InternalServerError,
                    ExceptionMessage = exception.Message,
                    Title = "somthing went wrong"
                };

                await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);
                httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;

                return true;
            }
           return false;
        }
    }
}
