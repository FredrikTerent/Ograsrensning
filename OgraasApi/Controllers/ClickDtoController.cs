using Microsoft.AspNetCore.Mvc;
using OgraasApi.Data;
using OgraasApi.Logic;
using OgraasApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OgraasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClickDtoController : ControllerBase
    {
        private readonly IPlayer playerRepo;
        private GameLogic Logic;

        public ClickDtoController(IPlayer playerRepo)
        {
            this.playerRepo = playerRepo;
            Logic = new GameLogic();
        }      

        // POST api/<ClickDtoController>
        [HttpPost("{id},{Row},{Col}")]
        public HitResponse Post([FromBody] int id, int Row, int Col)
        {

            int x= Row, y = Col;
            var player = playerRepo.GetByIdAsync(id).Result;
            var hitResponse = 
            Logic.Pangakrut(player, x, y);

            return hitResponse;
        }
      
    }
}
