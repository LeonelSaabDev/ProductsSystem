using SaleSystem2.Models;

namespace SaleSystem2.Repositories
{
    public interface IProductoRepository
    {
        Task<List<Productos>> GetAllAsync();
        Task<Productos?> GetByIdAsync(int id);
        Task<Productos> CreateAsync(Productos producto);
        Task<bool> UpdateAsync(Productos producto);
        Task<bool> DeleteAsync(int id);
    }
}
