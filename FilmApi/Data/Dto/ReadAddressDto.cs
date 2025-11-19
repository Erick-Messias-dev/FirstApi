using System.ComponentModel.DataAnnotations;

namespace FilmApi.Data.Dto;

public class ReadAddressDto
{
    public string Name { get; set; }
    public int Number { get; set; }
}
