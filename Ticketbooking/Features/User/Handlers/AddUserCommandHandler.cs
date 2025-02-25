using MediatR;
using Ticketbooking.Features.User.Commands;
using Ticketbooking.Services;

namespace Ticketbooking.Features.User.Handlers
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, ValueTask>
    {
        private readonly IUserService _userService;
        public AddUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<ValueTask> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
           await _userService.CreateAsync(request.user);
            return ValueTask.CompletedTask;
        }
    }
}
