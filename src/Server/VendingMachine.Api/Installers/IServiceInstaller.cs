using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace VendingMachine.Api.Installers
{
    public interface IServiceInstaller
    {
        void InstallerService(IServiceCollection services, IConfiguration configuration);
    }
}
