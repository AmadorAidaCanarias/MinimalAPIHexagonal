using MinimalApiWithStructure.Application.Domain.Dtos.ProductsDto;
using MinimalApiWithStructure.Enterprise.Domain.Entities;

namespace MinimalApiWithStructure.Enterprise.Domain.Extensions
{
    public static class ProductFromCreateProductDtoExtension
    {
        public static Product ProductFromCreateProductDto(this Product product, CreateProductDto newProduct)
        {
            return new Product()
            {
                Name = newProduct.Name,
            };
        }
    }
}
