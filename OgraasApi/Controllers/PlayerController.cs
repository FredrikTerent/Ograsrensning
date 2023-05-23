using Microsoft.AspNetCore.Mvc;
using OgraasApi.Data;
using OgraasApi.Models;
using System.Runtime.CompilerServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OgraasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayer playerRepo;

        public PlayerController(IPlayer playerRepo)
        {
            this.playerRepo = playerRepo;
        }
        // GET: api/<PlayerController>
        [HttpGet]
        public async Task<IEnumerable<Player>> Get()
        {
            return await playerRepo.GetAllAsync();
        }

        // GET api/<PlayerController>/5
        [HttpGet("{id}")]
        public async Task<Player> Get(int id)
        {
            return await playerRepo.GetByIdAsync(id);
        }

        // POST api/<PlayerController>
        [HttpPost]
        public async Task<Player> Post([FromBody] Player player)
        {
            return await playerRepo.CreateAsync(player);
        }

        // PUT api/<PlayerController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Player player)
        {
            await playerRepo.UpdateAsync(player);
        }

        // DELETE api/<PlayerController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await playerRepo.DeleteAsync(id);
        }
    }
}
