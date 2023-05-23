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
            [HttpGet]
            public async Task<IEnumerable<Weed>> Get()
            {
                return await weedRepo.GetAllAsync();
            }

            // GET api/<BoardController>/5
            [HttpGet("{id}")]
            public async Task<Weed> Get(int id)
            {
                return await weedRepo.GetByIdAsync(id);
            }

            // POST api/<BoardController>
            [HttpPost]
            public async Task<Weed> Post([FromBody] Weed weed)
            {
                return await weedRepo.CreateAsync(weed);
            }

            // PUT api/<BoardController>/5
            [HttpPut("{id}")]
            public async Task Put(int id, [FromBody] Weed weed)
            {
                await weedRepo.UpdateAsync(weed);
            }

            // DELETE api/<BoardController>/5
            [HttpDelete("{id}")]
            public async Task Delete(int id)
            {
                await weedRepo.DeleteAsync(id);
            }
        }
    }

