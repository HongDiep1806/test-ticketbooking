using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketbooking.Models.WebModels.User;

namespace Ticketbooking.Services
{
    public interface IUserService
    {
        Task<List<UserProfile>> GetAllAsync();
        Task CreateAsync(UserProfile entity);
    }
}
