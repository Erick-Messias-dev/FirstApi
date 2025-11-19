using System.ComponentModel.DataAnnotations;

namespace FilmApi.Data.Dto;

public class UpdateCinemaDto
{
    public string Name { get; set; }
    public string Number { get; set; }
}
