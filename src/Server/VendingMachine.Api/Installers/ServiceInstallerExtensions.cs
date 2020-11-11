using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace VendingMachine.Api.Installers
{
    public static class ServiceInstallerExtensions
    {
        public static void InstallServicesInAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            var ServiceInstallers = typeof(Startup).Assembly.ExportedTypes.Where(x => typeof(IServiceInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).Select(Activator.CreateInstance).Cast<IServiceInstaller>().ToList();

            ServiceInstallers.ForEach(installer => installer.InstallerService(services, configuration));
        }
    }
}
