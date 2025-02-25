using MediatR;
using Ticketbooking.Models.WebModels.User;

namespace Ticketbooking.Features.User.Commands
{
    public class AddUserCommand : IRequest<ValueTask>
    {
        public UserProfile user { get; set; }
        public AddUserCommand(UserProfile user)
        {
            this.user = user;
        }
    }
}
