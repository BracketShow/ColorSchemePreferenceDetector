using Microsoft.Extensions.DependencyInjection;

namespace ColorSchemePreferenceDetector
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddColorSchemePreferenceDetector(this IServiceCollection services) => 
            services.AddScoped<IColorSchemePreferenceDetector, ColorSchemePreferenceDetector>();
    }
}
