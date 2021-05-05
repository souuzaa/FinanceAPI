using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Profile.Api.Extension.DependencyInjection
{
    [ExcludeFromCodeCoverage]
    public static class SwaggerServiceExtension
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(x =>
            {
                x.AddServer(new OpenApiServer { Url = configuration["Swagger:UrlBase"] });
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "Profile Api", Version = "v1" });
                x.CustomSchemaIds(type => type.ToString());

                var xmlFileApi = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlFileApiModels = $"Finance.ApiModels.xml";

                var xmlPathApi = Path.Combine(AppContext.BaseDirectory, xmlFileApi);
                var xmlPathApiModels = Path.Combine(AppContext.BaseDirectory, xmlFileApiModels);

                x.IncludeXmlComments(xmlPathApi);
                x.IncludeXmlComments(xmlPathApiModels);
            });

            return services;
        }
    }
}
