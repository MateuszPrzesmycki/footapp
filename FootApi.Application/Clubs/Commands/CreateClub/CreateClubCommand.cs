
using MediatR;

namespace FootApi.Application.Clubs.Commands.CreateClub
{
    public class CreateClubCommand : IRequest<int>
    {
        public string ClubName { get; set; } = default!;
        public string Country { get; set; } = default!;
        public string StadiumName { get; set; } = default!;
        public int FoundedYear { get; set; }
    }
}
