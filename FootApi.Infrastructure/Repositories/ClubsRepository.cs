using FootApi.Domain.Entities;
using FootApi.Domain.Repositories;
using FootApi.Infrastructure.DbConextMain;
using Microsoft.EntityFrameworkCore;

namespace FootApi.Infrastructure.Repositories
{
    internal class ClubsRepository(FootApiDbContext dbContext) : IClubsRepository
    {
        public async Task<IEnumerable<Club>> GetClubsAsync() => await dbContext.Clubs.ToListAsync();

        public async Task<Club?> GetClubAsync(int id)
        {
            return await dbContext.Clubs.Include(c => c.Players).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<int> CreateClubAsync(Club club)
        {
            dbContext.Clubs.Add(club);
            await dbContext.SaveChangesAsync();
            return club.Id;
        }

        public async Task DeleteClubAsync(Club club)
        {
            dbContext.Clubs.Remove(club);
            await dbContext.SaveChangesAsync();
        }
        public async Task PatchClubAsync(Club club)
        {
            dbContext.Clubs.Update(club);
            await dbContext.SaveChangesAsync();
        }
    }
}
