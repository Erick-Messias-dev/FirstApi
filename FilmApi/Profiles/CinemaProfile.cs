using AutoMapper;
using FilmApi.Data.Dto;
using FilmApi.Domain.Models;

namespace FilmApi.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<Cinema, ReadCinemaDto>().ForMember(cinemaDto => cinemaDto.Address, opt => opt.MapFrom(cinema => cinema.Address))
            .ForMember(cinemaDto => cinemaDto.Sessions, opt => opt.MapFrom(cinema => cinema.Sessions ));
        CreateMap<UpdateCinemaDto, Cinema>();
    }
}
