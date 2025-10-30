using Microsoft.EntityFrameworkCore;

namespace hotellisting.api.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions<HotelListingDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

    }
}
//4jE713-@   a0E27IT*  r8pOvC9+
