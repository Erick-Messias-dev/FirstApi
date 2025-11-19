

using AutoMapper;
using FilmApi.Data.Dto;
using FilmApi.Domain.Models;

namespace FilmApi.Profiles;

public class FilmProfile : AutoMapper.Profile
{
    public FilmProfile()
    {
        CreateMap<CreateFilmDto, Film>();
        CreateMap<UpdateFilmDto, Film>();
        CreateMap<Film, UpdateFilmDto>();
        CreateMap<Film, ReadFilmDto>();
    }
}
