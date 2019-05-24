using System;
using System.Collections;
using System.Net;
using System.Security.Authentication;
using FluentValidation;
using KitcPPW.Filters.Exception;
using KitcPPW.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace KitcPPW.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class KitcExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is ValidationException)
            {
                context.HttpContext.Response.ContentType = "application/json";
                context.HttpContext.Response.StatusCode = (int) HttpStatusCode.BadRequest;
                var errorList = new ArrayList();
                foreach (var validationFailure in ((ValidationException) context.Exception).Errors)
                    errorList.Add(validationFailure.ErrorMessage);

                var res = new DefaultPayloadModel<ArrayList>
                {
                    Result = errorList,
                    Status = false,
                    Message = "Invalid Data."
                };

                context.Result = new JsonResult(res);

                return;
            }

            string exceptionType = "";

            var code = HttpStatusCode.InternalServerError;

            if (context.Exception is NotFoundException)
            {
                code = HttpStatusCode.NotFound;
                exceptionType = "Not Found.";
            }else if (context.Exception is AuthenticationException)
            {
                code = HttpStatusCode.Unauthorized;
                exceptionType = "You have not enough permission to view this content.";
            }

            context.HttpContext.Response.ContentType = "application/json";
            context.HttpContext.Response.StatusCode = (int) code;


            context.Result = new JsonResult(new DefaultPayloadModel<string[]>
            {
                Result = new string[]{ context.Exception.Message },
                Status = false,
                Message = exceptionType
            });
        }
    }
}