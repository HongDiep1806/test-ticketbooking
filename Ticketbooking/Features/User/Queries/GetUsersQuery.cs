using MediatR;
using Ticketbooking.Models.WebModels.User;

namespace Ticketbooking.Features.User.Queries
{
    public class GetUsersQuery : IRequest<List<UserProfile>>
    {

    }
}
