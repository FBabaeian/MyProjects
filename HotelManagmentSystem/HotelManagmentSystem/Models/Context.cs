using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using HotelModel.Models;

namespace HotelManagmentSystem.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
		public virtual DbSet<Bill> Bills { get; set; }
		public virtual DbSet<CheckIn> CheckIns { get; set; }
		public virtual DbSet<CheckOut> CheckOuts { get; set; }
		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<Laundry> Laundries { get; set; }
		public virtual DbSet<Order> Orders { get; set; }
		public virtual DbSet<RentCar> RentCars { get; set; }
		public virtual DbSet<Room> Rooms { get; set; }
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<Message> Messages { get; set; }

		public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}