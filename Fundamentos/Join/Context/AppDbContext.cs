using Fundamentos.Join.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fundamentos.Join.Context;

public class AppDbContext : DbContext
{
    //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    //{
    //}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //define o provedor do BD e a string de conexão
        optionsBuilder
          .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TesteJoins;" +
                        "Trusted_Connection=True;MultipleActiveResultSets=true" );

        //exibe as consultas SQL no console
        optionsBuilder
          .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
    }

    //mapeia as entidades para as tabelas do BD
    public DbSet<Setor> Setores { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }


}