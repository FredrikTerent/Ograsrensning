using OgraasApi.Models;

namespace OgraasApi.Data
{
    public class PlayerRepository : IPlayer
    {
        public async Task<Player> CreateAsync(Player player)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Player>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Player> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Player> UpdateAsync(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
