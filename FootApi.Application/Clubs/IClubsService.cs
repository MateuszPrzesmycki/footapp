using FootApi.Domain.Entities;

namespace FootApi.Application.Clubs
{
    public interface IClubsService
    {
        Task<IEnumerable<Club>> GetClubs();
        Task<Club?> GetClub(int id);
    }
}