using System.ComponentModel.DataAnnotations;

namespace FilmApi.Domain.Models;

public class Session
{
    [Key]
    [Required]  
    public int Id { get; set; }
}
