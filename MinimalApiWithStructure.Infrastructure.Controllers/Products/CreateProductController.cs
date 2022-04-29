using MinimalApiWithStructure.Application.Domain.Dtos.ProductsDto;
using MinimalApiWithStructure.Application.Ports.InputPorts.Products;
using MinimalApiWithStructure.Application.Ports.OutputPorts.Products;
using MinimalApiWithStructure.Infrastructure.AdaptersPresenters.Interfaces;

namespace MinimalApiWithStructure.Infrastructure.Controllers.Products
{
    public class CreateProductController
    {
        private readonly ICreateProductInputPort _createProductInputPort;
        private readonly ICreateProductOutputPort _createProductOutputPort;

        public CreateProductController(ICreateProductInputPort createProductInputPort, ICreateProductOutputPort createProductOutputPort) =>
            (_createProductInputPort, _createProductOutputPort) = (createProductInputPort, createProductOutputPort);

        public async Task<ProductDto> CreateProduct(CreateProductDto createProductDto)
        {
            await _createProductInputPort.Handle(createProductDto, new CancellationToken());
            return ((IPresenter<ProductDto>)_createProductOutputPort).Content;
        }
    }
}
