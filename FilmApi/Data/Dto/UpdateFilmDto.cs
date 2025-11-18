using System.ComponentModel.DataAnnotations;

namespace FilmApi.Data.Dto
{
    public class UpdateFilmDto
    {
        [Required(ErrorMessage = "O filme deve possuir um nome")]
        public string Title { get; set; }
        [Required(ErrorMessage = "O Filme Deve possuir um titulo")]
        [StringLength(50, ErrorMessage = "O tamanho não pode ser maior do que 50 caractéres")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "A duração tem que ser entre 80 a 200 min")]
        [Range(80, 200)]
        public int Duration { get; set; }
        [Required(ErrorMessage = "A nota deve er entre 1 a 5")]
        [Range(0, 5)]
        public int Grade { get; set; }

    }
}
