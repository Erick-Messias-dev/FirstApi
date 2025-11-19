using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FilmApi.Domain.Models;

public class Address
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required] 
    public string Street { get; set; }

    [Required]
    public int Number { get; set; }
}
