using MiApp.Aplication.Interfaces;
using MiApp.Domain;
using MiApp.Aplication.DTOs;


namespace MiApp.Aplication.Services;

public class ProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<ProductDto> AddAsync(ProductDto dto)
    {
        var product = new Product(
            Guid.NewGuid(),
            dto.Name,
            dto.Price,
            dto.Stock
            );

        await _repository.AddAsync(product);

        return new ProductDto(
            product.Id,
            product.Name,
            product.Price,
            product.Stock
            );
    }

    public async Task<ProductDto?> GetByIdAsync(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);

        if (product is null)
            return null;

        return new ProductDto(
            product.Id,
            product.Name,
            product.Price,
            product.Stock
            );
    }

}
