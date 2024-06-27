using DapperDay.Dtos.ProductDtos;

namespace DapperDay.Services
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task DeleteProductAsync(int id);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task<GetByIdProductDto> GetProductAsync(int id);
    }
}
