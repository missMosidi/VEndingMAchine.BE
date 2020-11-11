using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Api.Installers
{
    public class EntityFrameWorkServiceInstaller : IServiceInstaller
    {
        public void InstallerService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<VendingMachineDbContext>(options =>
            {
                options.UseLazyLoadingProxies()
                .UseSqlServer(configuration.GetConnectionString("LocalConnection").ToString())
                .EnableSensitiveDataLogging(false);
            });
        }
    }
}
