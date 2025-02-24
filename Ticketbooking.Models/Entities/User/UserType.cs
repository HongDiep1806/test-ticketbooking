using System.Security;

namespace Ticketbooking.Models.Entities.User
{
    public class UserType
    {
        public int UserTypeID { get; set; }
        public string Type { get; set; } = string.Empty;
        public ICollection<Permission> Permissions { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
