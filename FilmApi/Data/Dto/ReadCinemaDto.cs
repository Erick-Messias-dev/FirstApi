using System.ComponentModel.DataAnnotations;

namespace FilmApi.Data.Dto;

public class ReadCinemaDto
{
    public string Street { get; set; }
    public string Number { get; set; }
    public ReadAddressDto ReadAddressDto { get; set; }
}
