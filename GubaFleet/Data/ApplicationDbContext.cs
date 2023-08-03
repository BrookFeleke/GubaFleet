using Microsoft.EntityFrameworkCore;

namespace GubaFleet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }
    }
}
