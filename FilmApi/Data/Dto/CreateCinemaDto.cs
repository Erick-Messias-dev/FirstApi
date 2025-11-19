namespace FilmApi.Data.Dto;

public class CreateCinemaDto
{
    public string Name { get; set; }
    [Required]
    public string Number { get; set; }
}
