using OgraasApi.Models;

namespace OgraasApi.Data
{
    public interface IWeed
    {
        Task<Weed> GetByIdAsync(int? id);
        Task<IEnumerable<Weed>> GetAllAsync();
        Task<Weed> CreateAsync(Weed weed);
        Task<Weed> UpdateAsync(Weed weed);
        Task DeleteAsync(int id);
    }
}
