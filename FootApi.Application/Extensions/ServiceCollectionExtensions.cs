﻿using FluentValidation;
using FluentValidation.AspNetCore;
using FootApi.Application.Clubs;
using Microsoft.Extensions.DependencyInjection;


namespace FootApi.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IClubsService, ClubsService>();
            services.AddAutoMapper(typeof(ServiceCollectionExtensions).Assembly);
            services.AddValidatorsFromAssembly(typeof(ServiceCollectionExtensions).Assembly).AddFluentValidationAutoValidation();
        }
    }
}
