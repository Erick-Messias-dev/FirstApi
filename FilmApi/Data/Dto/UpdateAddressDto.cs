using System.ComponentModel.DataAnnotations;

namespace FilmApi.Data.Dto;

public class UpdateAddressDto
{
    public string Name { get; set; }
    public int Number { get; set; }
}
