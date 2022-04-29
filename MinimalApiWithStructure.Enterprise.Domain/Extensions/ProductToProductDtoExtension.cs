using MinimalApiWithStructure.Application.Domain.Dtos.ProductsDto;
using MinimalApiWithStructure.Enterprise.Domain.Entities;

namespace MinimalApiWithStructure.Enterprise.Domain.Extensions
{
    public static class ProductToProductDtoExtension
    {
        public static ProductDto ProductToProductDto(this Product product)
        {
            return new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
            };
        }
    }
}
