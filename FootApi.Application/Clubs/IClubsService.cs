using FootApi.Application.Clubs.Dtos;

namespace FootApi.Application.Clubs
{
    public interface IClubsService
    {
        Task<IEnumerable<ClubDto>> GetClubs();
        Task<ClubDto?> GetClub(int id);
        Task<int> Create(ClubCreateDto dto);
    }
}