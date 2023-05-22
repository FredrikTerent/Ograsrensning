using OgraasApi.Models;

namespace OgraasApi.Data
{
    public interface IWeed
    {
        Task<Weed> GetById(int? id);
        Task<IEnumerable<Weed>> GetAll();
        Task<Weed> Create(Weed weed);
        Task<Weed> Update(Weed weed);
        Task<Weed> Delete(int id);
    }
}
