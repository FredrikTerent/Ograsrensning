using Microsoft.AspNetCore.Mvc;
using OgraasApi.Data;
using OgraasApi.Models;
using System.Runtime.CompilerServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OgraasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly IBoard boardRepo;

        public BoardController(IBoard boardRepo)
        {
            this.boardRepo = boardRepo;
        }
        // GET: api/<BoardController>
        [HttpGet]
        public async Task<IEnumerable<Board>> Get()
        {
            return await boardRepo.GetAllAsync();
        }

        // GET api/<BoardController>/5
        [HttpGet("{id}")]
        public async Task<Board> Get(int id)
        {
            return await boardRepo.GetByIdAsync(id);
        }

        // POST api/<BoardController>
        [HttpPost]
        public async Task<Board> Post([FromBody] Board board)
        {
           return await boardRepo.CreateAsync(board);
        }

        // PUT api/<BoardController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Board board)
        {
          await boardRepo.UpdateAsync(board);
        }

        // DELETE api/<BoardController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await boardRepo.DeleteAsync(id);
        }
    }
}
