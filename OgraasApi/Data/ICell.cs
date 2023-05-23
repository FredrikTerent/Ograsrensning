using OgraasApi.Models;

namespace OgraasApi.Data
{
    public interface ICell
    {
        Task Create(Cell cell);
        Task Update(Cell cell);
        Task<Cell> GetById(int id);
        Task<IEnumerable<Cell>> GetAll();
        Task Delete(int id);
    }
}
