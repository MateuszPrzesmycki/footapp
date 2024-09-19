using MediatR;

namespace FootApi.Application.Clubs.Commands.DeleteClub
{
    public class DeleteClubCommand(int id) : IRequest<bool>
    {
        public int Id { get; } = id;
    }
}
