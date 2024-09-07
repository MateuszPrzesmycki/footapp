using FootApi.Application.Clubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootAPI.Controllers
{
    [ApiController]
    [Route("api/clubs")]
    public class ClubsController(IClubsService clubsService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetClubs()
        {
            var clubs = await clubsService.GetClubs();
            return Ok(clubs);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetClub([FromRoute] int id)
        {
            var club = await clubsService.GetClub(id);
            if (club == null) return NotFound();
            return Ok(club);
        }
    }
}
