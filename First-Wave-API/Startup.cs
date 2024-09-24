using Microsoft.AspNetCore.CookiePolicy;
using First_Wave_API.Configs;
using First_Wave_API.Middlewares;
using System.Text.Json.Serialization;


namespace First_Wave_API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public EnvVariables EnvVar { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            EnvVar = new EnvVariables(Configuration);
        }

        /**
         * Method used to configure and register service that will be used in all application
         * as a database service, authentication, message broker among others.
         */
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton<EnvVariables>();

            services.ConfigCoorsStartup(EnvVar);

            services.ConfigApiVersionStartup();

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.Secure = CookieSecurePolicy.Always;
                options.HttpOnly = HttpOnlyPolicy.Always;
                options.MinimumSameSitePolicy = SameSiteMode.Strict;
            });

            services.AddControllers()
                .AddJsonOptions(opt =>
                {
                    opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                });

            services.AddEndpointsApiExplorer();

            services.AddHttpContextAccessor();

            services.ConfigSwaggerStartup();

            //RegisterServices(services);
        }

        /**
         * Método usado para configurar como o aplicativo lida com solicitações HTTP.
         */
        public void Configure(WebApplication app)
        {
            app.ConfigHttpMiddlewares(EnvVar);
        }

        private static void RegisterServices(IServiceCollection services)
        {
            //Chamar a função de injeção de dependências da camada de IoC
        }
    }
}
