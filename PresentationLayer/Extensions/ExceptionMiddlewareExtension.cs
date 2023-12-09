using BusinessLayer.Abstract;
using EntityLayer.ErrorModels;
using EntityLayer.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace PresentationLayer.Extensions
{
    public static class ExceptionMiddlewareExtension
    {
        //static olan bütün sınıf üyeleri static olarak tanımlanır

        public static void ConfigureExceptionHandler(this WebApplication webApplication,
            ILoggerService logger)
        {
            webApplication.UseExceptionHandler(webApplicationError =>
            {
                webApplicationError.Run(async contex =>
                {
                    contex.Response.ContentType = "application/json";
                    
                    var contextFeature = contex.Features.Get<IExceptionHandlerFeature>(); // we look that is there a error . we try to find what there is a error

                    if(contextFeature is not null)
                    {
                        contex.Response.StatusCode = contextFeature switch
                        {
                            NotFoundException => StatusCodes.Status404NotFound,
                            _ => StatusCodes.Status500InternalServerError
                        };

                        logger.LogError($"Something went wrong: {contextFeature.Error}");
                        await contex.Response.WriteAsync(new ErrorDetails()
                        {
                            StatusCode = contex.Response.StatusCode,
                            Message = contextFeature.Error.Message
                        }.ToString());
                    }
                });
            });
        }

    }
}
