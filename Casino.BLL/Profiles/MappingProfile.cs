using AutoMapper;
using Casino.BLL.Models.Player;
using Casino.DAL.EntityModels;

namespace Casino.BLL.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PlayerInputModel, Player>();
            CreateMap<EditPlayerInputModel, Player>();
            CreateMap<Player, PlayerDTO>();
        }
    }
}
