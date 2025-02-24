namespace Ticketbooking.Models.Entities.User
{ 
    public class UserType_Permission
    {
        public int UserType_PermissionID { get; set; }
        public int UserTypeID { get; set; }
        public int PermissionID { get; set; }
        public UserType UserType { get; set; }
        public Permission Permission { get; set; }
    }
}
