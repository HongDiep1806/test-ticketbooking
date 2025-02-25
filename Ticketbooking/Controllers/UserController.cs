using MediatR;
using Microsoft.AspNetCore.Mvc;
using Ticketbooking.Features.User.Commands;
using Ticketbooking.Features.User.Queries;
using Ticketbooking.Models.WebModels.User;

namespace Ticketbooking.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> GetAll()
        {
            var query = new GetUsersQuery();
            await _mediator.Send(query);
            return Ok();
        }

        public async Task<IActionResult> Create([FromBody]UserProfile user)
        {
            var command = new AddUserCommand(user);
            await _mediator.Send(command);
            return Ok();
        }



    }
}
