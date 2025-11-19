using System.ComponentModel.DataAnnotations;

namespace FilmApi.Domain.Models;

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]    
    public string Name { get; set; }
    [Required]
    public string Number { get; set; }

}
