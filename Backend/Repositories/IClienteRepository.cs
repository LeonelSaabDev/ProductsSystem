using SaleSystem2.Models;

namespace SaleSystem2.Repositories
{
    public interface IClienteRepository
    {
        Task<List<Clientes>> GetAllAsync();
        Task<Clientes?> GetByIdAsync(int id);
        Task<Clientes> CreateAsync(Clientes cliente);
        Task<bool> UpdateAsync(Clientes cliente);
        Task<bool> DeleteAsync(int id);
    }
}
