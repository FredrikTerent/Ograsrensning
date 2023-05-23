using Microsoft.AspNetCore.Mvc;
using OgraasApi.Data;
using OgraasApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OgraasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class WeedController : ControllerBase
    {
        private readonly IWeed weedRepo;

        public WeedController(IWeed weedRepo)
        {
            this.weedRepo = weedRepo;
        }
        // GET: api/<BoardController>
        //[HttpGet]
        //public async Task<IEnumerable<Maskros>> GetAllMaskros()
        //{
        //    return await weedRepo.GetAllMaskrosAsync();
        //}
        
        //[HttpGet]
        //public async Task<IEnumerable<Kardborre>> GetAllKardborre()
        //{
        //    return await weedRepo.GetAllKardborreAsync();
        //}
        
        //[HttpGet]
        //public async Task<IEnumerable<Kvickrot>> GetAllKvickrot()
        //{
        //    return await weedRepo.GetAllKvickrotAsync();
        //}
       
        //[HttpGet]
        //public async Task<IEnumerable<Kirskal>> GetAllKirskal()
        //{
        //    return await weedRepo.GetAllKirskalAsync();
        //}

        [HttpGet]
        public async Task<IEnumerable<Weed>> GetAllWeed()
        {
            return await weedRepo.GetAllWeedAsync();
        }


        // GET api/<BoardController>/5
        //[HttpGet("{id}")]
        //public async Task<Maskros> GetMaskros(int id)
        //{
        //    return await weedRepo.GetMaskrosByIdAsync(id);
        //}

        //[HttpGet("{id}")]
        //public async Task<Kardborre> GetKardborre(int id)
        //{
        //    return await weedRepo.GetKardborreByIdAsync(id);
        //}

        //[HttpGet("{id}")]
        //public async Task<Kvickrot> GetKvickrot(int id)
        //{
        //    return await weedRepo.GetKvickrotByIdAsync(id);
        //}

        //[HttpGet("{id}")]
        //public async Task<Kirskal> GetKirskal(int id)
        //{
        //    return await weedRepo.GetKirskalByIdAsync(id);
        //}


        [HttpGet("{id}")]
        public async Task<Weed> GetWeed(int id)
        {
            return await weedRepo.GetWeedByIdAsync(id);
        }

        // POST api/<BoardController>
        [HttpPost]
        public async Task<Maskros> Post([FromBody] Maskros maskros)
        {
            return await weedRepo.CreateMaskrosAsync(maskros);
        }
        [HttpPost]
        public async Task<Kardborre> Post([FromBody] Kardborre kardborre)
        {
            return await weedRepo.CreateKardborreAsync(kardborre);
        }
        [HttpPost]
        public async Task<Kvickrot> Post([FromBody] Kvickrot kvickrot)
        {
            return await weedRepo.CreateKvickrotAsync(kvickrot);
        }
        [HttpPost]
        public async Task<Kirskal> Post([FromBody] Kirskal kirskal)
        {
            return await weedRepo.CreateKirskalAsync(kirskal);
        }

        //// PUT api/<BoardController>/5
        //[HttpPut("{id}")]
        //public async Task Put(int id, [FromBody] Maskros maskros)
        //{
        //    await weedRepo.UpdateMaskrosAsync(maskros);
        //}
        //[HttpPut("{id}")]
        //public async Task PutKirskal(int id, [FromBody] Kirskal kirskal)
        //{
        //    await weedRepo.UpdateKirskalAsync(kirskal);
        //}

        //[HttpPut("{id}")]
        //public async Task PutKvickrot(int id, [FromBody] Kvickrot kvickrot)
        //{
        //    await weedRepo.UpdateKvickrotAsync(kvickrot);
        //}
        //[HttpPut("{id}")]
        //public async Task PutKardborre(int id, [FromBody] Kardborre kardborre)
        //{
        //    await weedRepo.UpdateKardborreAsync(kardborre);
        //}


        //// DELETE api/<BoardController>/5
        //[HttpDelete("{id}")]
        //public async Task DeleteMaskrosAsync(int id)
        //{
        //    await weedRepo.DeleteMaskrosAsync(id);
        //}
        //[HttpDelete("{id}")]
        //public async Task DeleteKardborreAsync(int id)
        //{
        //    await weedRepo.DeleteKardborreAsync(id);
        //}
        //[HttpDelete("{id}")]
        //public async Task DeleteKvickrotAsync(int id)
        //{
        //    await weedRepo.DeleteKvickrotAsync(id);
        //}
        //[HttpDelete("{id}")]
        //public async Task DeleteKirskalAsync(int id)
        //{
        //    await weedRepo.DeleteKirskalAsync(id);
        //}
    }
}

