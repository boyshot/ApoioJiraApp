using ApoioJiraApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApoioJiraApp.Data
{
  public class ApoioTarefasContext : DbContext
  {
    public ApoioTarefasContext(DbContextOptions<ApoioTarefasContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Tarefa> Tarefas { get; set; }
    public DbSet<Artefato> Artefatos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Usuario>().ToTable("TBUSUARIO");
      modelBuilder.Entity<Tarefa>().ToTable("TBTAREFA");
      modelBuilder.Entity<Artefato>().ToTable("TBARTEFATO");
    }
  }
}
