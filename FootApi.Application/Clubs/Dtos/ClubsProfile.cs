using AutoMapper;
using FootApi.Application.Clubs.Commands.CreateClub;
using FootApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootApi.Application.Clubs.Dtos
{
    public class ClubsProfile : Profile
    {
        public ClubsProfile()
        {
            CreateMap<CreateClubCommand, Club>();
            CreateMap<Club, ClubDto>();
        }
    }
}
