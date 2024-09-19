using FootApi.Application.Clubs.Dtos;
using MediatR;

namespace FootApi.Application.Clubs.Queries.GetAllClubs
{
    public class GetAllClubsQuery : IRequest<IEnumerable<ClubDto>>
    {
    }
}
