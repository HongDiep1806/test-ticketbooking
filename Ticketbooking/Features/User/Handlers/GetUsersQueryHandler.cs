using MediatR;
using Ticketbooking.Features.User.Queries;
using Ticketbooking.Models.WebModels.User;
using Ticketbooking.Services;

namespace Ticketbooking.Features.User.Handlers
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, List<UserProfile>>
    {
        private readonly IUserService _userService;
        public async Task<List<UserProfile>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _userService.GetAllAsync();
            return users.Select(u => new UserProfile
            {
                UserID = u.UserID,
                Email = u.Email,
                FullName = u.FullName,
                Password = u.Password,
                UserTypeID = u.UserID
            }).ToList();
        }
    }
}
