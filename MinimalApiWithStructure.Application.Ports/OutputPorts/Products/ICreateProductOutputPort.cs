using MinimalApiWithStructure.Application.Domain.Dtos.ProductsDto;

namespace MinimalApiWithStructure.Application.Ports.OutputPorts.Products
{
    public interface ICreateProductOutputPort
    {
        Task Handle(ProductDto newProduct);
    }
}
