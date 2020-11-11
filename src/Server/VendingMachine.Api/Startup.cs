using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VendingMachine.Api.Installers;
using VendingMachine.Api.Services.Configuration;
using VendingMachine.Api.Services.Messages;
using VendingMachine.Api.Services.Responses.Commons;
using VendingMachine.Persistance.EntityFramework.Context;
using VendingMachine.Persistance.EntityFramework.DataSeeds;

namespace VendingMachine.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //AppilicationModule.Configure();

            HttpResponseMessages.InternalErrorMessage = "Something Happened With Our Server.";
            HttpResponseMessages.NoContentMessage = "Content Was Found From The System.";
            HttpResponseMessages.NotFoundMessage = "Record Could Not Be Found From The System.";
            HttpResponseMessages.NotImplementedMessage = "Request transaction could not be Implemented, Please Check if is not deleted or the status has been changes";


            HttpResponseMessages.CreatedMessage = "Successfully Added.";
            HttpResponseMessages.UpdatedMessage = "Successfully Updated.";
            HttpResponseMessages.DeletedMessage = "Successfully Deleted.";
            HttpResponseMessages.RestoredMessage = "Successfully Restored.";


        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.InstallServicesInAssembly(this.Configuration);

            services.AddSingleton<InternalServerResponse>(new InternalServerResponse
            {
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Message = HttpResponseMessages.InternalErrorMessage,
                SubMessage = "Our Team Is Working on It.",
                Instructions = new List<string>()
            });

            //services.AddScoped<ICreateJsonWebToken, CreateJsonWebToken<VendingMachineDbContext>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = scope.ServiceProvider.GetService<VendingMachineDbContext>();

                context.Database.Migrate();
                context.EnsureDatabaseSeeded();
            }

            app.UseCors("WebSitePolicy");
            // swagger setup
            var swaggerOptions = new SwaggerConfigurations();

            Configuration.GetSection(nameof(SwaggerConfigurations)).Bind(swaggerOptions);



            app.UseSwagger(option =>
            {

                option.RouteTemplate = swaggerOptions.JsonRoute;

            });
            app.UseSwaggerUI(option =>
            {

                //option.SwaggerEndpoint(swaggerOptions.UIEndpoint, swaggerOptions.Description);
                foreach (var description in provider.ApiVersionDescriptions)
                {
                    option.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant());
                }
                option.RoutePrefix = string.Empty;
            });
            app.UseSwagger();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
