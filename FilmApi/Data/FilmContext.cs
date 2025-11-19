using FilmApi.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmApi.Data;

public class FilmContext : DbContext
{
    public FilmContext(DbContextOptions<FilmContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Film>().ToTable("films", "public");
    }
    public DbSet<Film> Films { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Address> Addresses { get; set; }
}
