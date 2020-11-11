using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VendingMachine.Application.Confugurations.MappingProfiles.Application;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Api.Installers
{
    public class AutoMapperServiceInstaller : IServiceInstaller
    {
        public void InstallerService(IServiceCollection services, IConfiguration configuration)
        {
            //services.AddAutoMapper(typeof(StatusMap));

            services.AddScoped(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new StatusMap(provider.GetService<VendingMachineDbContext>()));
                cfg.AddProfile(new ProductImagesMap(provider.GetService<VendingMachineDbContext>()));
                cfg.AddProfile(new ProductMap(provider.GetService<VendingMachineDbContext>()));
                cfg.AddProfile(new StockInventoryMap(provider.GetService<VendingMachineDbContext>()));
                cfg.AddProfile(new SaleMap(provider.GetService<VendingMachineDbContext>()));

            }).CreateMapper());
        }
    }
}
