using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlayerApi.Models;
using PlayerApi.Services;

namespace PlayerApi.Controllers
{
    [ApiController] 
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
       

        private readonly ILogger<PlayerController> _logger;
        private IPlayerService _service;

        public PlayerController(ILogger<PlayerController> logger, IPlayerService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public IActionResult GetPlayers()
        {
            IEnumerable<Player> list = _service.GetPlayers();
            if (list != null)
                return Ok(list);
            else
                return BadRequest();
        }

        
        
        [HttpGet("{name}", Name="GetPlayer")]
        public IActionResult GetPlayerByName(string name)
        {
            Player obj = _service.GetPlayersByName(name);
            if (obj!=null)
                return Ok(obj);
            return BadRequest();
        }


        [HttpGet("sport/{sport}")]
        public IActionResult GetPlayersBySport(string sport)
        {
            IEnumerable<Player> list = _service.GetPlayersBySport(sport);
            if (list != null)
                return Ok(list);
            else
                return BadRequest();
        }

        [HttpGet("team/{team}")]
        public IActionResult GetPlayersByTeam(string team)
        {
            IEnumerable<Player> list = _service.GetPlayersByTeam(team);
            if (list != null)
                return Ok(list);
            else
                return BadRequest();
        }


        [HttpPost]
        public IActionResult CreatePlayer(Player p) {
            _service.CreatePlayer(p);
            return CreatedAtRoute("GetPlayer", new{name=p.Name}, p);
        }

        [HttpPut("{name}")]
        public IActionResult UpdatePlayer(string name, Player playerIn) {
            
            _service.UpdatePlayer(name, playerIn);
            return NoContent();
        }

        [HttpDelete("{name}")]
        public IActionResult DeletePlayer(string name) {
            _service.DeletePlayer(name);
            return NoContent();
        }
    }
}