using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmApi.Domain.Models;

public class Address
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    [Column("Name")]
    public string Street { get; set; }

    [Required]
    public int Number { get; set; }
    
    public virtual Cinema Cinema { get; set; }
}
