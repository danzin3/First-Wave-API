using Asp.Versioning;

namespace First_Wave_API.Configs
{
    internal static class VersioningConfigs
    {
        public static void ConfigApiVersionStartup(this IServiceCollection services)
        {
            services.AddApiVersioning(options =>
            {
                options.DefaultApiVersion = new ApiVersion(1,0);
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
            }).EnableApiVersionBinding();
        }
    }
}
