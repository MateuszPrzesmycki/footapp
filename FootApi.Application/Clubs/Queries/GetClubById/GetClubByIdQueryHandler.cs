using AutoMapper;
using FootApi.Application.Clubs.Dtos;
using FootApi.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootApi.Application.Clubs.Queries.GetClubById
{
    internal class GetClubByIdQueryHandler(ILogger<GetClubByIdQueryHandler> logger, IMapper mapper, IClubsRepository clubsRepository ) : IRequestHandler<GetClubByIdQuery, ClubDto?>
    {
        public async Task<ClubDto?> Handle(GetClubByIdQuery request, CancellationToken cancellationToken)
        {
            logger.LogInformation($"Get club id: {request.Id}");
            var club = await clubsRepository.GetClubAsync(request.Id);
            if (club == null) return null;
            else return mapper.Map<ClubDto>(club);
        }
    }
}
