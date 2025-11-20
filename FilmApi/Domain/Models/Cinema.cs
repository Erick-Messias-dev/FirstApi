using System.ComponentModel.DataAnnotations;

namespace FilmApi.Domain.Models;

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]    
    public string Street { get; set; }
    [Required]
    public int AddressId { get; set; }
    public virtual Address Address { get; set; }

}
