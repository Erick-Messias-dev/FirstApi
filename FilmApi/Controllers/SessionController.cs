using AutoMapper;
using FilmApi.Data;
using FilmApi.Data.Dto;
using FilmApi.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmApi.Controllers;

public class SessionController : ControllerBase
{
    private FilmContext _context;
    private IMapper _mapper;

    public SessionController(FilmContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaSessao(CreateSessionDto dto)
    {
        Session session = _mapper.Map<Session>(dto);
        _context.Sessions.Add(session);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaSessoesPorId), new { Id = session.Id }, session);
    }

    [HttpGet]
    public IEnumerable<ReadSessionDto> RecuperaSessoes()
    {
        return _mapper.Map<List<ReadSessionDto>>(_context.Sessions.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaSessoesPorId(int id)
    {
        Session sessao = _context.Sessions.FirstOrDefault(sessao => sessao.Id == id);
        if (sessao != null)
        {
            ReadSessionDto sessaoDto = _mapper.Map<ReadSessionDto>(sessao);

            return Ok(sessaoDto);
        }
        return NotFound();
    }
}

