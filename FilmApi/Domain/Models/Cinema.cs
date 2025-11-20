using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmApi.Domain.Models;

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    [Column("Street")]
    public string Name { get; set; }
    [Required]
    public int AddressId { get; set; }
    public virtual Address Address { get; set; }
    public virtual  ICollection<Session> Sessions { get; set; }

}
