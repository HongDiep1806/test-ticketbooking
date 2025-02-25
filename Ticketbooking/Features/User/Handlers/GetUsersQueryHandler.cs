using MediatR;
using Microsoft.AspNetCore.Identity;
using Ticketbooking.Features.User.Queries;
using Ticketbooking.Models.WebModels.User;

namespace Ticketbooking.Features.User.Handlers
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, List<UserProfile>>
    {
        private readonly IUserService _userService;
        public Task<List<UserProfile>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
