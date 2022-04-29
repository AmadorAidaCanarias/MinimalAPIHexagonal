using MinimalApiWithStructure.Application.Domain.Dtos.ProductsDto;

namespace MinimalApiWithStructure.Application.Ports.InputPorts.Products
{
    public interface ICreateProductInputPort
    {
        Task Handle(CreateProductDto createProduct, CancellationToken cancellationToken);
    }
}
