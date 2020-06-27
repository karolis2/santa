using Darbuotojai.Application.Services;
using Darbuotojai.Architecture.Infra.Data.Repositories;
using Darbuotojai.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace Darbuotojai.Infrastructure.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //CleanArchitecture.Application
            services.AddScoped<IDarbuotojaiService, DarbuotojaiService>();

            //CleanArchitecture.Domain.Interfaces | CleanArchitecture.Infra.Data.Repositories
            services.AddScoped<IDarbuotojaiRepository, DarbuotojaiRepository>();
        }
    }
}