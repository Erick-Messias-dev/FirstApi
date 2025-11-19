using System.ComponentModel.DataAnnotations;

namespace FilmApi.Data.Dto;

public class CreateAddressDto
{
    public string Name { get; set; }

    public int Number { get; set; }
}
