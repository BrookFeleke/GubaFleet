using GubaFleet.Models;
using Microsoft.EntityFrameworkCore;

namespace GubaFleet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<SparePart> SpareParts { get; set; }
        public DbSet<Group> Groups { get; set; }    
    }
}
