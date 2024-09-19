
using MediatR;

namespace FootApi.Application.Clubs.Commands.PatchClub
{
    public class PatchClubCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string ClubName { get; set; } = default!;
        public string Country { get; set; } = default!;
    }
}
