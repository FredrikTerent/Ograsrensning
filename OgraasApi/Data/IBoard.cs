using OgraasApi.Models;

namespace OgraasApi.Data
{
    public interface IBoard
    {
        Task Create (Board board);
        Task Update (Board board);
        Task <Board> GetById (int id);
        Task <IEnumerable<Board>> GetAll();
        Task Delete (int id);
    }
}
