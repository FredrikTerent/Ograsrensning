using OgraasApi.Models;

namespace OgraasApi.Data
{
    public interface IBoard
    {
        Task<Board> CreateAsync(Board board);
        Task<Board> UpdateAsync(Board board);
        Task<Board> GetByIdAsync(int id);
        Task<IEnumerable<Board>> GetAllAsync();
        Task DeleteAsync(int id);
    }
}
