using ATOM.Repository.Context;
using Microsoft.AspNetCore.Identity;

namespace ATOM.API.Extensions
{
    public static class IdentityExtension
    {
        public static void AddIdentityExtension(this IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();
        }
    }
}
