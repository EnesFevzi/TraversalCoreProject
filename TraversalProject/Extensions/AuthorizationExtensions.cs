using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace TraversalProject.WebUI.Extensions
{
    public static class AuthorizationExtensions
    {
        public static void AddCustomAuthorization(this IServiceCollection services)
        {
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            // Diğer yapılandırmaları da buraya ekleyebilirsiniz
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                options.AccessDeniedPath = "/ErrorPage/Index";
                options.LoginPath = "/Login/Index/";
                options.LogoutPath = "/Login/Logout";
                options.SlidingExpiration = true;
            });
        }
    }
}
