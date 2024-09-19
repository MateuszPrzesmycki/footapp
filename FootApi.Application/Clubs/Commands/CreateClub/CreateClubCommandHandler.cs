using AutoMapper;
using FootApi.Domain.Entities;
using FootApi.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FootApi.Application.Clubs.Commands.CreateClub
{
    public class CreateClubCommandHandler(ILogger<CreateClubCommandHandler> logger, IMapper mapper, IClubsRepository clubsRepository) : IRequestHandler<CreateClubCommand, int>
    {
        public async Task<int> Handle(CreateClubCommand request, CancellationToken cancellationToken)
        {
            logger.LogInformation("Create new club");
            var obj = mapper.Map<Club>(request);
            return await clubsRepository.CreateClubAsync(obj);
        }
    }
}
