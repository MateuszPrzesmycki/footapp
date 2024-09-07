using FootApi.Domain.Entities;
using FootApi.Domain.Repositories;
using Microsoft.Extensions.Logging;

namespace FootApi.Application.Clubs
{
    internal class ClubsService(IClubsRepository clubsRepository, ILogger<ClubsService> logger) : IClubsService
    {
        public async Task<Club> GetClub(int id)
        {
            logger.LogInformation("Get club");
            return await clubsRepository.GetClubAsync(id);
        }

        public async Task<IEnumerable<Club>> GetClubs()
        {
            logger.LogInformation("Get all clubs");
            return await clubsRepository.GetClubsAsync();
        }
    }
}
