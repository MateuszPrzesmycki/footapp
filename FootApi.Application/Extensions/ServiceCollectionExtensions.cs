using FluentValidation;
using FluentValidation.AspNetCore;
using FootApi.Application.Clubs;
using Microsoft.Extensions.DependencyInjection;


namespace FootApi.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var appAssembly = typeof(ServiceCollectionExtensions).Assembly;
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(appAssembly));
            services.AddAutoMapper(appAssembly);
            services.AddValidatorsFromAssembly(appAssembly).AddFluentValidationAutoValidation();
        }
    }
}
