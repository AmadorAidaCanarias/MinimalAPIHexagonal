using MinimalApiWithStructure.Application.Domain.Dtos.ProductsDto;
using MinimalApiWithStructure.Application.Ports.OutputPorts.Products;
using MinimalApiWithStructure.Infrastructure.AdaptersPresenters.Interfaces;

namespace MinimalApiWithStructure.Infrastructure.AdaptersPresenters.Products
{
    public class CreateProductPresenter : ICreateProductOutputPort, IPresenter<ProductDto>
    {
        public ProductDto Content { get; private set; }

        public Task Handle(ProductDto newProduct)
        {
            Content = newProduct;
            return Task.CompletedTask;
        }
    }
}
