using FootApi.Domain.Entities;
namespace FootApi.Domain.Repositories
{
    public interface IClubsRepository
    {
        Task<IEnumerable<Club>> GetClubsAsync();
        Task<Club?> GetClubAsync(int id);
        Task<int> CreateClubAsync(Club club);
        Task DeleteClubAsync(Club club);
        Task PatchClubAsync(Club club);
    }
}
