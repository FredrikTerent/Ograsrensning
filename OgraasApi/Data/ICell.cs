using OgraasApi.Models;

namespace OgraasApi.Data
{
    public interface ICell
    {
        Task<Cell> CreateAsync(Cell cell);
        Task<Cell> UpdateAsync(Cell cell);
        Task<Cell> GetByIdAsync(int id);
        Task<IEnumerable<Cell>> GetAllAsync();
        Task DeleteAsync(int id);
    }
}
