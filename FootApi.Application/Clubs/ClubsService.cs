using AutoMapper;
using FootApi.Application.Clubs.Dtos;
using FootApi.Domain.Repositories;
using Microsoft.Extensions.Logging;

namespace FootApi.Application.Clubs
{
    internal class ClubsService(IClubsRepository clubsRepository, ILogger<ClubsService> logger, IMapper mapper) : IClubsService
    {
        public async Task<ClubDto?> GetClub(int id)
        {
            logger.LogInformation("Get club");
            var club = await clubsRepository.GetClubAsync(id);
            if (club == null) return null;
            else return mapper.Map<ClubDto>(club);
        }

        public async Task<IEnumerable<ClubDto>> GetClubs()
        {
            logger.LogInformation("Get all clubs");
            var clubs = await clubsRepository.GetClubsAsync();
            return mapper.Map<IEnumerable<ClubDto>>(clubs);
        }
    }
}
