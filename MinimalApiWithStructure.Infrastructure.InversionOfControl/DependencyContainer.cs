using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MinimalApiWithStructure.Application.Interactors;
using MinimalApiWithStructure.Infrastructure.AdaptersPresenters;
using MinimalApiWithStructure.Infrastructure.GatewaySqlServer;

namespace MinimalApiWithStructure.Infrastructure.InversionOfControl
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddProjectDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddInteractors();
            services.AddPresenters();
            return services;
        }
    }
}
