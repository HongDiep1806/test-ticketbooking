using Microsoft.EntityFrameworkCore;
using Ticketbooking.Models.Entities.User;
namespace Ticketbooking.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }  
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<UserType_Permission> UserTypes_Permissions { get; set; }
    }
}
