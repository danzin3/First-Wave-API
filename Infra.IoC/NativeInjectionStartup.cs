using Microsoft.Extensions.DependencyInjection;
using Domain.Entities;
using Domain.Interfaces.Responses;
using Application.UseCases.Word.ResponsesDto;
using Application.UseCases.Word.Create;

namespace Infra.IoC
{
    public static class NativeInjectionStartup
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<CreateWordUseCase>();
            services.AddScoped<ISingleResponse<WordEntity>, SingleWordResponse>();
            return services;
        }
    }
}
