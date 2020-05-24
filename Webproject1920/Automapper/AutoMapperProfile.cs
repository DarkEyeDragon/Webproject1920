using AutoMapper;
using System.Runtime.InteropServices.ComTypes;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.ViewModels;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Automapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            

            CreateMap<Clubs, ClubVM>()
                .ForMember(dest => dest.StadionId, opts => opts.MapFrom(src => src.Stadion));
            CreateMap<Stadions, StadionVM>();

            CreateMap<UserTest, UserVM>();

            CreateMap<Ticketsale, TicketSaleVM>()
                .ForMember(dest => dest.UserId, opts => opts.MapFrom(src => src.User))
                .ForMember(dest => dest.TicketType, opts => opts.MapFrom(src => src.TicketType))
                .ForMember(dest => dest.GameId, opts => opts.MapFrom(src => src.Game));

            CreateMap<Games, GameVM>()
                .ForMember(dest => dest.HomeTeam, opts => opts.MapFrom(src => src.HomeTeam))            
                .ForMember(dest => dest.AwayTeam, opts => opts.MapFrom(src => src.AwayTeam));
            CreateMap<Games, CalendarVM>()
                .ForMember(dest => dest.Game, opts => opts.MapFrom(src => src));

            CreateMap<Stadions, StadionVM>();
        }
    }
}
