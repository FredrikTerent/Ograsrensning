using Microsoft.EntityFrameworkCore;
using OgraasApi.Models;

namespace OgraasApi.Data
{
    public class PlayerRepository : IPlayer
    {
        private readonly ApplicationDbContext dbContext;

        public PlayerRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Player> CreateAsync(Player player)
        {
            dbContext.Add(player);
            await dbContext.SaveChangesAsync();
            return player;
        }

        public async Task DeleteAsync(int id)
        {
            var player = await dbContext.Players.FindAsync(id);
            dbContext.Remove(player);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Player>> GetAllAsync()
        {
            return await dbContext.Players.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<Player> GetByIdAsync(int id)
        {
            return await dbContext.Players.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Player> UpdateAsync(Player player)
        {
            dbContext.Update(player);
            await dbContext.SaveChangesAsync();
            return player;
        }
    }
}
