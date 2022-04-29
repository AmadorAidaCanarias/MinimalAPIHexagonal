namespace MinimalApiWithStructure.Application.Domain.Dtos.ProductsDto
{
    public class CreateProductDto
    {
        public string Name { get; set; }

        public CreateProductDto(string name)
        {
            Name = name;
        }
    }
}
