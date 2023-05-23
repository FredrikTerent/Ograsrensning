using Microsoft.EntityFrameworkCore;
using OgraasApi.Models;

namespace OgraasApi.Data
{
    public class WeedRepository : IWeed
    {
        private readonly ApplicationDbContext _dbContext;

        public WeedRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Maskros> CreateMaskrosAsync(Maskros maskros)
        {
            _dbContext.Add(maskros);
            await _dbContext.SaveChangesAsync();
            return maskros;
        }

        public async Task<Kardborre> CreateKardborreAsync(Kardborre kardborre)
        {
            _dbContext.Add(kardborre);
            await _dbContext.SaveChangesAsync();
            return kardborre;
        }

        public async Task<Kirskal> CreateKirskalAsync(Kirskal kirskal)
        {
            _dbContext.Add(kirskal);
            await _dbContext.SaveChangesAsync();
            return kirskal;
        }

        public async Task<Kvickrot> CreateKvickrotAsync(Kvickrot kvickrot)
        {
            _dbContext.Add(kvickrot);
            await _dbContext.SaveChangesAsync();
            return kvickrot;
        }

        public async Task DeleteKardborreAsync(int id)
        {
            var detOgras = _dbContext.Weeds.FindAsync(id);
            _dbContext.Remove(detOgras);
            await _dbContext.SaveChangesAsync();
                        
        }

        public async Task DeleteKirskalAsync(int id)
        {
            var detOgras = _dbContext.Weeds.FindAsync(id);
            _dbContext.Remove(detOgras);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteKvickrotAsync(int id)
        {
            var detOgras = _dbContext.Weeds.FindAsync(id);
            _dbContext.Remove(detOgras);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteMaskrosAsync(int id)
        {
            var detOgras = _dbContext.Weeds.FindAsync(id);
            _dbContext.Remove(detOgras);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Kardborre>> GetAllKardborreAsync()
        {
            return await _dbContext.Set<Kardborre>().ToListAsync();
        }

        public async Task<IEnumerable<Kirskal>> GetAllKirskalAsync()
        {
            return await _dbContext.Set<Kirskal>().ToListAsync();
        }

        public async Task<IEnumerable<Kvickrot>> GetAllKvickrotAsync()
        {
            return await _dbContext.Set<Kvickrot>().ToListAsync();
        }

        public async Task<IEnumerable<Maskros>> GetAllMaskrosAsync()
        {
            return await _dbContext.Set<Maskros>().ToListAsync();
        }

        public async Task<IEnumerable<Weed>> GetAllWeedAsync()
        {
            return await _dbContext.Set<Weed>().ToListAsync();
        }

        public async Task<Kardborre> GetKardborreByIdAsync(int? id)
        {
            return await _dbContext.Set<Kardborre>().FindAsync(id);
        }

        public async Task<Kirskal> GetKirskalByIdAsync(int? id)
        {
            return await _dbContext.Set<Kirskal>().FindAsync(id);
        }

        public async Task<Kvickrot> GetKvickrotByIdAsync(int? id)
        {
            return await _dbContext.Set<Kvickrot>().FindAsync(id);
        }

        public async Task<Maskros> GetMaskrosByIdAsync(int? id)
        {
            return await _dbContext.Set<Maskros>().FindAsync(id);
        }
        public async Task<Weed> GetWeedByIdAsync(int id)
        {
            return await _dbContext.Set<Weed>().FindAsync(id);
        }

        public async Task<Maskros> UpdateMaskrosAsync(Maskros maskros)
        {
            _dbContext.Update(maskros);
            await _dbContext.SaveChangesAsync();
            return maskros;
        }

        public async Task<Kardborre> UpdateKardborreAsync(Kardborre kardborre)
        {
            _dbContext.Update(kardborre);
            await _dbContext.SaveChangesAsync();
            return kardborre;
        }

        public async Task<Kvickrot> UpdateKvickrotAsync(Kvickrot kvickrot)
        {
            _dbContext.Update(kvickrot);
            await _dbContext.SaveChangesAsync();
            return kvickrot;
        }

        public async Task<Kirskal> UpdateKirskalAsync(Kirskal kirskal)
        {
            _dbContext.Update(kirskal);
            await _dbContext.SaveChangesAsync();
            return kirskal;
        }


    }
}
