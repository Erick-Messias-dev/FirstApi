using System.ComponentModel.DataAnnotations;

namespace FilmApi.Domain.Models;

public class Session
{
    [Key]
    [Required]  
    public int Id { get; set; }
    [Required]
    public int FilmId { get; set; }
    public virtual Film Film { get; set; }
}
