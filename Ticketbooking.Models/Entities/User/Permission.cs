namespace Ticketbooking.Models.Entities.User
{
    public class Permission
    {
        public int PermissionID { get; set; }
        public string Description { get; set; }
        public ICollection<UserType> UserTypes { get; set; }
    }
}
