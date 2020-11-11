using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using VendingMachine.Api.Services.Configuration;

namespace VendingMachine.Api.Installers
{
    public class JWTAuthenticationServiceInstaller : IServiceInstaller
    {

        public void InstallerService(IServiceCollection services, IConfiguration configuration)
        {
            var jwtSettings = new JWTConfigurations();

            configuration.GetSection(nameof(JWTConfigurations)).Bind(jwtSettings);

            services.AddSingleton(jwtSettings);

            services.AddAuthentication(configureOptions: x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(option =>
            {
                option.SaveToken = true;

                option.TokenValidationParameters = new TokenValidationParameters
                {
                    //what to validate
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    RequireExpirationTime = true,
                    ValidateLifetime = true,
                    //setup validate data
                    ValidIssuer = jwtSettings.Site,
                    ValidAudience = jwtSettings.Site,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SigningKey))

                };
            });
        }
    }
}

