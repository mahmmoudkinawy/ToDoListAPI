using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;

namespace ToDoList.Attributes
{
    public class ToDoAuthorizeAttribute : TypeFilterAttribute
    {
        public ToDoAuthorizeAttribute() : base(typeof(ToDoAuthorizeFilter))
        {
        }
    }

    public class ToDoAuthorizeFilter : IAuthorizationFilter
    {
        private readonly List<string> AuthHeaders = new List<string>
        {
            "my-secure-auth-header-user1",
            "my-secure-auth-header-user2",
            "my-secure-auth-header-user3"
        };

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var authHeader = "Authorization";
            if (context.HttpContext.Request.Headers.ContainsKey(authHeader))
            {
                var authValue = context.HttpContext.Request.Headers[authHeader].ToString();
                if (AuthHeaders.Contains(authValue)) return;
            }

            context.Result = new UnauthorizedResult();
        }
    }
}
