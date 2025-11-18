using System.ComponentModel.DataAnnotations;

namespace FilmApi.Domain.Models;

public interface IFilm
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Duration { get; set; }  
    public int Grade { get; set; }
}