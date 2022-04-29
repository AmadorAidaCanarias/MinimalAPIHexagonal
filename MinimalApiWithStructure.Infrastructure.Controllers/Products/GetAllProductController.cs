using MinimalApiWithStructure.Application.Domain.Dtos.ProductsDto;
using MinimalApiWithStructure.Application.Ports.InputPorts.Products;
using MinimalApiWithStructure.Application.Ports.OutputPorts.Products;
using MinimalApiWithStructure.Infrastructure.AdaptersPresenters.Interfaces;

namespace MinimalApiWithStructure.Infrastructure.Controllers.Products
{
    public class GetAllProductController
    {
        private readonly IGetAllProductsInputPort _getAllProductInputPort;
        private readonly IGetAllProductsOuputPort _getAllProductsOutputPort;

        public GetAllProductController(IGetAllProductsInputPort getAllProductInputPort, IGetAllProductsOuputPort getAllProductsOutputPort) =>
            (_getAllProductInputPort, _getAllProductsOutputPort) = (getAllProductInputPort, getAllProductsOutputPort);

        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {
            await _getAllProductInputPort.Handle();
            return ((IPresenter<IEnumerable<ProductDto>>)_getAllProductsOutputPort).Content;
        }

    }
}
