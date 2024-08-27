using Microsoft.EntityFrameworkCore;
using SistemaPromocao.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Escritor> Escritores { get; set; }
    public DbSet<Promotor> Promotores { get; set; }
    public DbSet<Bodybuilder> Bodybuilders { get; set; }
    public DbSet<Vlogger> Vloggers { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuração adicional do modelo, se necessário
    }
}