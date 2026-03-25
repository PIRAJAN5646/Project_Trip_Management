using Microsoft.EntityFrameworkCore;
using Project2.Models;
namespace Project2.Datas
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Bookings> bookings { get; set; }
        public DbSet<Expenses> expenses { get; set; }
        public DbSet<Locations> locations { get; set; }
        public DbSet<Media> media { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<TripMembers> tripMembers { get; set; }
        public DbSet<Trips> trips { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Notifications> notifications { get; set; }

    }
}
