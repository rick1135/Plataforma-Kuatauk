using Microsoft.EntityFrameworkCore;
using ProjetoKatuak.Models;

namespace ProjetoKatuak.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Exercicio> Exercicios { get; set; }
}

