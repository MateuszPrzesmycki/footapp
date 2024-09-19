using FootApi.Application.Clubs.Dtos;
using MediatR;

namespace FootApi.Application.Clubs.Queries.GetClubById
{
    public class GetClubByIdQuery : IRequest<ClubDto?>
    {
        public GetClubByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
