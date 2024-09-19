using FootApi.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FootApi.Application.Clubs.Commands.DeleteClub
{
    public class DeleteClubCommandHandler(ILogger<DeleteClubCommandHandler> logger, IClubsRepository clubsRepository) : IRequestHandler<DeleteClubCommand, bool>
    {
        public async Task<bool> Handle(DeleteClubCommand request, CancellationToken cancellationToken)
        {
            logger.LogInformation($"Delete club id: {request.Id}");
            var club = await clubsRepository.GetClubAsync(request.Id);
            if (club == null) return false;
            else
            {
                await clubsRepository.DeleteClubAsync(club);
                return true;
            }
        }
    }
}
