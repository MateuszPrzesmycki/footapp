using AutoMapper;
using FootApi.Application.Clubs.Dtos;
using FootApi.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FootApi.Application.Clubs.Queries.GetAllClubs
{
    public class GetAllClubsQueryHandler(ILogger<GetAllClubsQueryHandler> logger, IMapper mapper, IClubsRepository clubsRepository) : IRequestHandler<GetAllClubsQuery, IEnumerable<ClubDto>>
    {
        public async Task<IEnumerable<ClubDto>> Handle(GetAllClubsQuery request, CancellationToken cancellationToken)
        {
            logger.LogInformation("Get all clubs");
            var clubs = await clubsRepository.GetClubsAsync();
            return mapper.Map<IEnumerable<ClubDto>>(clubs);
        }
    }

}
