using System.ComponentModel.DataAnnotations;

namespace FilmApi.Data.Dto;

public class ReadCinemaDto
{
    public int Id { get; set; }
    public string Street { get; set; }
    
    public ReadAddressDto Address { get; set; }
    public ICollection<ReadSessionDto> Sessions { get; set; }
}
