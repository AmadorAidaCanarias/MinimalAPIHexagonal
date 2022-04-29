using MinimalApiWithStructure.Application.Ports.InputPorts.Products;
using MinimalApiWithStructure.Application.Ports.OutputPorts.Products;
using MinimalApiWithStructure.Enterprise.Domain.Entities;
using MinimalApiWithStructure.Enterprise.Domain.Extensions;
using MinimalApiWithStructure.Enterprise.Domain.Interfaces.Repositories;

namespace MinimalApiWithStructure.Application.Interactors.Products
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        private readonly IProductRepository _productRespository;
        private readonly IGetAllProductsOuputPort _getAllProductsOutputPort;

        public GetAllProductsInteractor(IProductRepository productRespository, IGetAllProductsOuputPort getAllProductsOutputPort) =>
            (_productRespository, _getAllProductsOutputPort) = (productRespository, getAllProductsOutputPort);

        public Task Handle()
        {
            IEnumerable<Product> products = _productRespository.GetAll();
            _getAllProductsOutputPort.Handle(products.Select(p => p.ProductToProductDto()).ToList());
            return Task.CompletedTask;
        }
    }
}
