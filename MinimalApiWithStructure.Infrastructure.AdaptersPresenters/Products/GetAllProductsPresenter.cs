using MinimalApiWithStructure.Application.Domain.Dtos.ProductsDto;
using MinimalApiWithStructure.Application.Ports.OutputPorts.Products;
using MinimalApiWithStructure.Infrastructure.AdaptersPresenters.Interfaces;

namespace MinimalApiWithStructure.Infrastructure.AdaptersPresenters.Products
{
    public class GetAllProductsPresenter : IGetAllProductsOuputPort, IPresenter<IEnumerable<ProductDto>>
    {
        public IEnumerable<ProductDto> Content { get; private set; }

        public Task Handle(IEnumerable<ProductDto> products)
        {
            Content = products;
            return Task.CompletedTask;
        }
    }
}
