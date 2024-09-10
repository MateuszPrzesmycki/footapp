using FootApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootApi.Domain.Repositories
{
    public interface IClubsRepository
    {
        Task<IEnumerable<Club>> GetClubsAsync();
        Task<Club?> GetClubAsync(int id);
        Task<int> CreateClubAsync(Club club);
    }
}
