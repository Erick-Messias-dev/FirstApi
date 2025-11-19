using AutoMapper;
using FilmApi.Data.Dto;
using FilmApi.Domain.Models;

namespace FilmApi.Profiles;

public class AddressProfile : Profile
{
    public AddressProfile()
    {
        CreateMap<CreateAddressDto, Address>();
        CreateMap<Address, ReadAddressDto>();
        CreateMap<UpdateAddressDto, Address>();
    }

}
