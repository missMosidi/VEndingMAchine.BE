using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using VendingMachine.Application.BusinessLogic.Application.Statuses.Query;

namespace VendingMachine.Api.Installers
{
    public class MVCSeviceInstaller : IServiceInstaller
    {
        public void InstallerService(IServiceCollection services, IConfiguration configuration)
        {

            services.AddCors(opt => 
            {
                opt.AddPolicy("WebSitePolicy", policy => 
                {
                    policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().SetIsOriginAllowedToAllowWildcardSubdomains();
                });
                opt.AddDefaultPolicy(policy =>
                    policy.WithOrigins(new[] { "https://localhost:5092", "http://localhost:5093" })
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials());
            });

            services
                .AddControllers()
                .AddApplicationPart(Assembly.Load(new AssemblyName("VendingMachine.Api.Services")))
                .AddJsonOptions(options => options.JsonSerializerOptions.WriteIndented = true)
                .AddNewtonsoftJson(options => {options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;});

            services
                .AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services
                .AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services
                .AddMediatR(typeof(GetAllStatusHandlerQuery).Assembly);

        }
    }
}
