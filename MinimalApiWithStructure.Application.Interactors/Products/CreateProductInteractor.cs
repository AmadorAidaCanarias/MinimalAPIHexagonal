using MinimalApiWithStructure.Application.Domain.Dtos.ProductsDto;
using MinimalApiWithStructure.Application.Ports.InputPorts.Products;
using MinimalApiWithStructure.Application.Ports.OutputPorts.Products;
using MinimalApiWithStructure.Enterprise.Domain.Entities;
using MinimalApiWithStructure.Enterprise.Domain.Extensions;
using MinimalApiWithStructure.Enterprise.Domain.Interfaces.Repositories;

namespace MinimalApiWithStructure.Application.Interactors.Products
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICreateProductOutputPort _createProductOutputPort;

        public CreateProductInteractor(IProductRepository productRepository, IUnitOfWork unitOfWork, ICreateProductOutputPort createProductOutputPort) =>
            (_productRepository, _unitOfWork, _createProductOutputPort) = (productRepository, unitOfWork, createProductOutputPort);

        public async Task Handle(CreateProductDto createProduct, CancellationToken cancellationToken)
        {
            Product newProduct = new Product().ProductFromCreateProductDto(createProduct);
            _productRepository.Add(newProduct);
            await _unitOfWork.SaveChangesAssync(cancellationToken);
            await _createProductOutputPort.Handle(newProduct.ProductToProductDto());
        }
    }
}
