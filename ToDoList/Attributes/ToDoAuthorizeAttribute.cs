using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;

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
        private readonly Dictionary<Guid, string> AuthHeaders = new Dictionary<Guid, string>
        {
            { Guid.Parse("9620d021-e670-4da6-a8a0-404e6c43ca36"), "my-secure-auth-header-user1" },
            { Guid.Parse("9b04ea9c-af8a-4c5f-bc93-f8756049d1fc"), "my-secure-auth-header-user2" },
            { Guid.Parse("b8e4b292-c2ca-4e1b-976a-db27cbfa8ca2"),  "my-secure-auth-header-user3" }
        };

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var authHeader = "Authorization";
            if (context.HttpContext.Request.Headers.ContainsKey(authHeader))
            {
                var authValue = context.HttpContext.Request.Headers[authHeader].ToString();
                if (AuthHeaders.ContainsValue(authValue))
                {
                    var userId = AuthHeaders.Single(x => x.Value == authValue).Key;
                    context.HttpContext.Items["UserId"] = userId;
                    return;
                }
            }

            context.Result = new UnauthorizedResult();
        }
    }
}
