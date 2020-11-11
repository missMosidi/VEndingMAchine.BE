using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System;
using Swashbuckle.AspNetCore.Filters;
using VendingMachine.Api.Services.Configuration;

namespace VendingMachine.Api.Installers
{
    public class SwaggerInstaller : IServiceInstaller
    {
        public void InstallerService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddApiVersioning(options =>
            {
                options.ReportApiVersions = true;
            });

            services.AddVersionedApiExplorer(
                options =>
                {
                    // add the versioned api explorer, which also adds IApiVersionDescriptionProvider service
                    // note: the specified format code will format the version as "'v'major[.minor][-status]"
                    options.GroupNameFormat = "'v'VVV";

                    // note: this option is only necessary when versioning by url segment. the SubstitutionFormat
                    // can also be used to control the format of the API version in route templates
                    options.SubstituteApiVersionInUrl = true;
                });

            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            services.AddSwaggerGen(c =>
            {
                c.CustomOperationIds(apiDesc =>
                {
                    return apiDesc.TryGetMethodInfo(out MethodInfo methodInfo) ? methodInfo.Name : null;
                });

                //c.SwaggerDoc("v1", new OpenApiInfo { Title = "FoShoConnect API", Version = "V1" });

                c.ExampleFilters();

                c.AddSecurityDefinition(name: "Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization Header using the Bearer Scheme",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {new OpenApiSecurityScheme{ Reference = new OpenApiReference
                    {
                        Id = "Bearer",
                        Type = ReferenceType.SecurityScheme
                    }}, new List<string>()}

                });

                c.OperationFilter<SwaggerDefaultValues>();


                var xmlFile_2 = $"{Assembly.Load("VendingMachine.Api.Services").GetName().Name}.xml";
                var xmlPath_2 = Path.Combine(AppContext.BaseDirectory, xmlFile_2);

                c.IncludeXmlComments(xmlPath_2);


                //var server = new OpenApiServer();
                //var localServer = new OpenApiServer();s

                //server.Url = "";
                //localServer.Url = "https://localhost:5061/";

                //c.AddServer(server);
                //c.AddServer(localServer);

            });

            services.AddSwaggerExamplesFromAssemblies(Assembly.Load("VendingMachine.Api.Services"));

        }
    }
}
