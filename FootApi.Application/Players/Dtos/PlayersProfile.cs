using AutoMapper;
using FootApi.Domain.Entities;

namespace FootApi.Application.Players.Dtos
{
    internal class PlayersProfile : Profile
    {
        public PlayersProfile()
        {
            CreateMap<Player, PlayerDto>();
        }
    }
}
