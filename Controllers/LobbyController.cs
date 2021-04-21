using lobby_service.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lobby_service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LobbyController : ControllerBase
    {
        private readonly LobbyContext _lobbyContext;

        public LobbyController(LobbyContext lobbyContext)
        {
            _lobbyContext = lobbyContext;
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            try
            {
                bool response = _lobbyContext.Lobbys.Any();

                if (!response)
                    return BadRequest(new { message = "no characters found" });

                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.ToString() });
            }
        }
    }
}
