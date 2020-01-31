using Microsoft.EntityFrameworkCore;

namespace ParksLookupApi.Models
{
    public class ParksLookupApiContext : DbContext
    {
        public ParksLookupApiContext(DbContextOptions<ParksLookupApiContext> options)
            : base(options)
        {
        }
        public DbSet<Park> Parks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
{
        builder.Entity<Park>()
            .HasData(
                new Park { ParkId = 1, Name = "Yosemite", State = "California", Rating = 5, City = "Mariposa", Review = "It's Yosemite, dude. So yeah, it's pretty awesome." },
                new Park { ParkId = 2, Name = "Glacier", State = "Montana", Rating = 5, City = "Columbia Falls", Review = "Feels like a John Wayne movie." },
                new Park { ParkId = 3, Name = "Arches", State = "Utah", Rating = 4, City = "Moab", Review = "How did the Mormons get such a pretty state." },
                new Park { ParkId = 4, Name = "Jackson Falls", State = "Illinois", Rating = 2, City = "Ozark", Review = "It's not too grand, but it's better than the cornfields." },
                new Park { ParkId = 5, Name = "Rocky Mountain", State = "Colorado", Rating = 5, City = "Estes Park", Review = "So beautiful I had trouble breathing, or maybe that was just the elevation." }
            );
}
    }
}