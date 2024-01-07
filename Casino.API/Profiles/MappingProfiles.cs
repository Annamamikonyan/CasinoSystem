using AutoMapper;
using Casino.API.Models.Players;
using Casino.BLL.Models.Player;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Casino.API.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddPlayerApiModel, PlayerInputModel>();
            CreateMap<EditPlayerApiModel, EditPlayerInputModel>();
        }
    }
}
