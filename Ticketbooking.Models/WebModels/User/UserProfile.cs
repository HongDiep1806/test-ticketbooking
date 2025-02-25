using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketbooking.Models.Entities.User;

namespace Ticketbooking.Models.WebModels.User
{
    public class UserProfile
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserTypeID { get; set; }
    }
}
