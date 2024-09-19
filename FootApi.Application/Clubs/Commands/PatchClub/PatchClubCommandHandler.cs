using FootApi.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FootApi.Application.Clubs.Commands.PatchClub
{
    public class PatchClubCommandHandler(ILogger<PatchClubCommandHandler> logger, IClubsRepository clubsRepository) : IRequestHandler<PatchClubCommand, bool>
    {
        public async Task<bool> Handle(PatchClubCommand request, CancellationToken cancellationToken)
        {
            logger.LogInformation($"Update club id: {request.Id}");
            var club = await clubsRepository.GetClubAsync(request.Id);
            if (club == null) return false;
            else
            {
                club.ClubName = request.ClubName;
                club.Country = request.Country;
                await clubsRepository.PatchClubAsync(club);
                return true;
            }
        }
    }

}
