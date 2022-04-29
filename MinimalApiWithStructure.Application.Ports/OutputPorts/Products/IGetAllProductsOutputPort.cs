using MinimalApiWithStructure.Application.Domain.Dtos.ProductsDto;

namespace MinimalApiWithStructure.Application.Ports.OutputPorts.Products
{
    public interface IGetAllProductsOuputPort
    {
        Task Handle(IEnumerable<ProductDto> products);
    }
}
