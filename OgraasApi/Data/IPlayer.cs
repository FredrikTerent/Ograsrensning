using OgraasApi.Models;

namespace OgraasApi.Data
{
    public interface IPlayer
    {
        Task<Player> CreateAsync(Player player);
        Task<Player> UpdateAsync(Player player);
        Task DeleteAsync(int id);
        Task<IEnumerable<Player>> GetAllAsync();
        Task<Player> GetByIdAsync(int id);

    }
}
