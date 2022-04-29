using Microsoft.Extensions.DependencyInjection;
using MinimalApiWithStructure.Application.Ports.OutputPorts.Products;
using MinimalApiWithStructure.Infrastructure.AdaptersPresenters.Products;

namespace MinimalApiWithStructure.Infrastructure.AdaptersPresenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<ICreateProductOutputPort, CreateProductPresenter>();
            services.AddScoped<IGetAllProductsOuputPort, GetAllProductsPresenter>();
            return services;
        }
    }
}
