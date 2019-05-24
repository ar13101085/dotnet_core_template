using System;
using System.Security.Authentication;
using KitcPPW.KitcAttribute;
using Microsoft.AspNetCore.Mvc.Filters;

namespace KitcPPW.Filters
{
    public class AuthorizationFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            #region Get Action Role value

            var t = context.Controller.GetType();
            var actionName = ((dynamic) context.ActionDescriptor).ActionName;
            var listAttribute = t.GetMethod(actionName).GetCustomAttributes(typeof(Attribute), true);
            foreach (var attr in listAttribute)
                if (attr is RoleAttribute)
                {
                    var roleAttr = (RoleAttribute) attr;
                    if (!context.HttpContext.User.HasClaim(x => x.Value == roleAttr.UniqueValue))
                        throw new AuthenticationException("You have not enough permission");
                }

            #endregion
        }


        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Go Executed");
        }
    }
}