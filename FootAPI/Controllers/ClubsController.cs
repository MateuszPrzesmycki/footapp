using FootApi.Application.Clubs;
using FootApi.Application.Clubs.Commands.CreateClub;
using FootApi.Application.Clubs.Commands.DeleteClub;
using FootApi.Application.Clubs.Commands.PatchClub;
using FootApi.Application.Clubs.Dtos;
using FootApi.Application.Clubs.Queries.GetAllClubs;
using FootApi.Application.Clubs.Queries.GetClubById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FootAPI.Controllers
{
    [ApiController]
    [Route("api/clubs")]
    public class ClubsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetClubs()
        {
            var clubs = await mediator.Send(new GetAllClubsQuery());
            return Ok(clubs);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetClub([FromRoute] int id)
        {
            var club = await mediator.Send(new GetClubByIdQuery(id));
            if (club == null) return NotFound();
            return Ok(club);
        }
        [HttpPost]
        public async Task<IActionResult> CreateClub([FromBody] CreateClubCommand command)
        {

            int id = await mediator.Send(command);
            return CreatedAtAction(nameof(GetClubs), new { id }, null);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteClub([FromRoute] int id)
        {
            bool isDeleted = await mediator.Send(new DeleteClubCommand(id));
            return isDeleted ? NoContent() : NotFound(); 
        }
        [HttpPatch]
        public async Task<IActionResult> PatchClub([FromBody]PatchClubCommand club)
        {
            bool isUpdated = await mediator.Send(club);
            return isUpdated ? NoContent() : NotFound();
        }
    }
}
