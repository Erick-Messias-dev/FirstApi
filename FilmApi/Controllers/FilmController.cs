using AutoMapper;
using FilmApi.Data;
using FilmApi.Data.Dto;
using FilmApi.Domain.Models;
using FilmApi.Migrations;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace FilmApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FilmController : ControllerBase
    {
        private FilmContext _context;
        private IMapper _mapper;

        public FilmController(FilmContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddFilm([FromBody] CreateFilmDto filmDto)
        {
            Film film = _mapper.Map<Film>(filmDto);
            _context.Films.Add(film);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetFilmByID), new { id = film.Id, }, film);
        }
        [HttpGet]
        public IEnumerable<ReadFilmDto> GetFilm([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            return _mapper.Map<List<ReadFilmDto>>(_context.Films.Skip(skip).Take(take).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetFilmByID(int id)
        {
            var film = _context.Films.FirstOrDefault(f => f.Id == id);
            if (film == null) return NotFound();
            var filmDto = _mapper.Map<ReadFilmDto>(film);
            return Ok(filmDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFilm(int id, [FromBody] UpdateFilmDto filmDto)
        {
            var film = _context.Films.FirstOrDefault(f => f.Id == id);
            if (film == null) return NotFound();
            _mapper.Map(filmDto, film);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpPatch("{id}")]
        public IActionResult UpdatePartialFilm(int id, JsonPatchDocument<UpdateFilmDto> patch)
        {
            var film = _context.Films.FirstOrDefault(f => f.Id ==id );
            if (film == null) return NotFound();

            var filmToUpdate = _mapper.Map<UpdateFilmDto>(film);
            
            patch.ApplyTo(filmToUpdate, ModelState);

            if (!TryValidateModel(filmToUpdate))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(filmToUpdate, film);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult FilmDelete(int id)
        {
            var film = _context.Films.FirstOrDefault(f => f.Id == id);
            if (film == null) return NotFound();
            _context.Films.Remove(film);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
