using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using LaboratorioEstudos.API.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
}
