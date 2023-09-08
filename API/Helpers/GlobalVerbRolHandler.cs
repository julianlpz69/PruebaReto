using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace API.Helpers
{
    public class GlobalVerbRolHandler : AuthorizationHandler<GlobalVerbRolRequirement>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GlobalVerbRolHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, GlobalVerbRolRequirement requirement)
        {
            var roles = context.User.FindAll(c => string.Equals(c.Type, ClaimTypes.Role)).Select(c => c.Value);
            var verb = _httpContextAccessor.HttpContext?.Request.Method;

            if (String.IsNullOrEmpty(verb)){throw new Exception($"request cann't be null");}

            foreach (var role in roles)
            {
                if (requirement.IsAllowed(role, verb))
                {
                    context.Succeed(requirement);
                    return Task.CompletedTask;
                }
            } 
            context.Fail();
            return Task.CompletedTask;
        }
    }
}