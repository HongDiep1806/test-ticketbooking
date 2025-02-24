namespace Ticketbooking.Models.Entities.User
{
    public class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserTypeID { get; set; }
        public UserType UserType { get; set; }
    }
}
