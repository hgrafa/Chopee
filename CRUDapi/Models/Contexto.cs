using Microsoft.EntityFrameworkCore;

namespace CRUDapi.Models {

  public class Contexto : DbContext {

    public DbSet<Pessoa> Pessoas { get; set; }

    public Contexto(DbContextOptions<Contexto> opcoes)
      : base(opcoes){

    }

  }

}