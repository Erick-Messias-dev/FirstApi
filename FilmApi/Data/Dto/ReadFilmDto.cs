using System.ComponentModel.DataAnnotations;

namespace FilmApi.Data.Dto
{
    public class ReadFilmDto
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        
        public int Duration { get; set; }
       
        public int Grade { get; set; }
        public DateTime ApointmentTime { get; set; } = DateTime.Now;
    }
}
