using Microsoft.AspNetCore.Diagnostics;

namespace GlobalExceptionHandling
{
    public class AppNotImplementationExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync
              (HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            if (exception is NotImplementedException)
            {
                var response = new ErrorResponse()
                {
                    statusCode = StatusCodes.Status501NotImplemented,
                    ExceptionMessage = exception.Message,
                    Title = "somthing went wrong"
                };

                await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);
                httpContext.Response.StatusCode = StatusCodes.Status501NotImplemented;

                return true;
            }
            return false;
        }

    }
}
