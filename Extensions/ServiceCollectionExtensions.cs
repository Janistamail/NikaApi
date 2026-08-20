using NikaApi.Services;

namespace NikaApi.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ICategoryService, CategoryService>();

        // Register additional services here as the API grows

        return services;
    }
}
