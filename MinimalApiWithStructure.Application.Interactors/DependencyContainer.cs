using Microsoft.Extensions.DependencyInjection;
using MinimalApiWithStructure.Application.Interactors.Products;
using MinimalApiWithStructure.Application.Ports.InputPorts.Products;

namespace MinimalApiWithStructure.Application.Interactors
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddInteractors(this IServiceCollection services)
        {
            services.AddTransient<ICreateProductInputPort, CreateProductInteractor>();
            services.AddTransient<IGetAllProductsInputPort, GetAllProductsInteractor>();
            return services;
        }
    }
}
