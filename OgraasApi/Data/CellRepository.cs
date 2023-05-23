using Microsoft.EntityFrameworkCore;
using OgraasApi.Models;

namespace OgraasApi.Data
{
    public class CellRepository : ICell
    {
        private readonly ApplicationDbContext _dbContext;

        public CellRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<Cell> CreateAsync(Cell cell)
        {
            _dbContext.Add(cell);
            await _dbContext.SaveChangesAsync();
            return cell;
        }

        public async Task DeleteAsync(int id)
        {
            var cell = _dbContext.Cells.FirstOrDefault(c => c.Id == id);
            if (cell != null)
            {
                _dbContext.Remove(cell);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Cell>> GetAllAsync()
        {
            var cellList = await _dbContext.Cells.Include(c=>c.Weed).ToListAsync();
            return cellList;    
        }

        public async Task<Cell> GetByIdAsync(int id)
        {
            var cell = await _dbContext.Cells.FirstOrDefaultAsync(c => c.Id == id);
            return cell;
        }

        public async Task<Cell> UpdateAsync(Cell cell)
        {
            _dbContext.Update(cell);
            await _dbContext.SaveChangesAsync();
            return cell;
        }
    }
}
