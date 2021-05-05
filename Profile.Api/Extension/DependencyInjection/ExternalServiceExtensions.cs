using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Profile.Api.Services;
using Profile.Api.Services.Factories;

namespace Profile.Api.Extension.DependencyInjection
{
    [ExcludeFromCodeCoverage]
    public static class ExternalServiceExtensions
    {
        public static IServiceCollection AddExternalService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProfileServiceFactory, ProfileServiceFactory>();
            services.AddScoped<ICreateProfileService, CreateProfileService>();

            return services;
        }
    }
}