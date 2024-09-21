using First_Wave_API.Configs;

namespace First_Wave_API.Middlewares
{
    internal static class HttpMiddlewaresStartup
    {
        public static void ConfigHttpMiddlewares(this WebApplication app, EnvVariables env)
        {
            if (env?.CorsOptions?.PolicyName is null) throw new ArgumentNullException(nameof(env));

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                    c.SwaggerEndpoint("/swagger/v2/swagger.json", "v2");
                });
            }

            app.UseCors(env.CorsOptions.PolicyName);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
