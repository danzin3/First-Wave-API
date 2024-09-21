using Microsoft.OpenApi.Models;
using First_Wave_API.Filters;

namespace First_Wave_API.Configs
{
    internal static class SwaggerConfigs
    {
        public static void ConfigSwaggerStartup(this IServiceCollection services)
        {
            services.AddSwaggerGen(opt => {
                opt.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "First Wave API",
                    Version = "v1",
                });
                opt.SwaggerDoc("v2", new OpenApiInfo
                {
                    Title = "First Wave API",
                    Version = "v2"
                });
                opt.OperationFilter<DefaultSwaggerVersion>();
            });
        }
    }
}
