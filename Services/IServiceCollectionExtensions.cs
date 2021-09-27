using Microsoft.Extensions.DependencyInjection;

namespace UmbracoProject.Services
{
    public static class IServiceCollectionExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<ContentHelper>();
        }
    }
}
