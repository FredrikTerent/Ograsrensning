using OgraasApi.Models;

namespace OgraasApi.Data
{
    public class PlayerRepository : IPlayer
    {
        public Task Create(Player player)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cell>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Player> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
