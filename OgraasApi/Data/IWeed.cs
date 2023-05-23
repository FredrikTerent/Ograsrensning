using OgraasApi.Models;

namespace OgraasApi.Data
{
    public interface IWeed
    {
        Task<Maskros> GetMaskrosByIdAsync(int? id);
        Task<IEnumerable<Maskros>> GetAllMaskrosAsync();
        Task<Maskros> CreateMaskrosAsync(Maskros maskros);
        Task<Maskros> UpdateMaskrosAsync(Maskros maskros);
        Task DeleteMaskrosAsync(int id);

        Task<Kardborre> GetKardborreByIdAsync(int? id);
        Task<IEnumerable<Kardborre>> GetAllKardborreAsync();
        Task<Kardborre> CreateKardborreAsync(Kardborre kardborre);
        Task<Kardborre> UpdateKardborreAsync(Kardborre kardborre);
        Task DeleteKardborreAsync(int id);

        Task<Kvickrot> GetKvickrotByIdAsync(int? id);
        Task<IEnumerable<Kvickrot>> GetAllKvickrotAsync();
        Task<Kvickrot> CreateKvickrotAsync(Kvickrot kvickrot);
        Task<Kvickrot> UpdateKvickrotAsync(Kvickrot kvickrot);
        Task DeleteKvickrotAsync(int id);

        Task<Kirskal> GetKirskalByIdAsync(int? id);
        Task<IEnumerable<Kirskal>> GetAllKirskalAsync();
        Task<Kirskal> CreateKirskalAsync(Kirskal kirskal);
        Task<Kirskal> UpdateKirskalAsync(Kirskal kirskal);
        Task DeleteKirskalAsync(int id);

    }
}
