using Microsoft.EntityFrameworkCore;
using FootApi.Domain.Entities;

namespace FootApi.Infrastructure.DbConextMain
{
    public class FootApiDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Club> Clubs { get; set; }

        public FootApiDbContext(DbContextOptions<FootApiDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>()
                .HasMany(c => c.Players)
                .WithOne(p => p.CurrentClub)
                .HasForeignKey(p => p.CurrentClubId);
        }

    }
}
