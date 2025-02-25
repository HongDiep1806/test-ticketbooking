using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketbooking.Models.Entities.User;
using Ticketbooking.Models.WebModels.User;
using Ticketbooking.Repositories;

namespace Ticketbooking.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task CreateAsync(UserProfile entity)
        {
            var user = new User
            {
                UserID = entity.UserID,
                Email = entity.Email,
                FullName = entity.FullName,
                Password = entity.Password,
                UserTypeID = entity.UserTypeID
            };
            await _userRepository.CreateAsync(user);
        }

        public async Task<List<UserProfile>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return users.Select(u => new UserProfile
            {
                UserTypeID = u.UserTypeID,
                UserID = u.UserID,
                Email = u.Email,
                FullName = u.FullName,
                Password = u.Password,
            }).ToList();
        }
    }
}
