using Microsoft.AspNetCore.Mvc;
using OgraasApi.Data;
using OgraasApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OgraasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CellController : ControllerBase
    {
        private readonly ICell cellRepo;

        public CellController(ICell cellRepo)
        {
            this.cellRepo = cellRepo;
        }
        // GET: api/<CellController>
        [HttpGet]
        public async Task<IEnumerable<Cell>> Get()
        {
            return await cellRepo.GetAllAsync();
        }

        // GET api/<CellController>/5
        [HttpGet("{id}")]
        public async Task<Cell> Get(int id)
        {
            return await cellRepo.GetByIdAsync(id);
        }

        // POST api/<CellController>
        [HttpPost]
        public async Task<Cell> Post([FromBody] Cell cell)
        {
            return await cellRepo.CreateAsync(cell);
        }

        // PUT api/<CellController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Cell cell)
        {
            await cellRepo.UpdateAsync(cell);
        }

        // DELETE api/<CellController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await cellRepo.DeleteAsync(id);
        }
    }
}
