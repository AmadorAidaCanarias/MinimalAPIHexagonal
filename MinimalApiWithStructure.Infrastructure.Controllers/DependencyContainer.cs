using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using MinimalApiWithStructure.Application.Domain.Validators.ProductsValidators;

namespace MinimalApiWithStructure.Infrastructure.Controllers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateProductDtoValidator>());
            return services;
        }
    }
}
