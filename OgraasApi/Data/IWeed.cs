using OgraasApi.Models;

namespace OgraasApi.Data
{
    public interface IWeed
    {
        Task<Weed> GetById(int? id);
        Task<IEnumerable<Weed>> GetAll();
        Task Create(Weed weed);
        Task Update(Weed weed);
        Task Delete(int id);
    }
}
