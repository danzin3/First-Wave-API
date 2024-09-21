using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace First_Wave_API.Filters
{
    internal class DefaultSwaggerVersion : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var apiVersion = operation.Parameters?.FirstOrDefault(p => p.Name == "version");
            if (apiVersion != null)
            {
                apiVersion.Schema.Default = new OpenApiString("v1");
            }
        }
    }
}
