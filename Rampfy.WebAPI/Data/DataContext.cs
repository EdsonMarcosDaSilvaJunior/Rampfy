using Microsoft.EntityFrameworkCore;
using Rampfy.WebAPI.Models;

namespace Rampfy.WebAPI.Data
{
  public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Venda> Vendas { get; set; } = null!;
        public DbSet<Usuario> Usuarios { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder){ 
          builder.Entity<Venda>().HasData(new List<Venda>(){
            new Venda(1,111,DateTime.Now.AddDays(-12),10.5),
            new Venda(2,222,DateTime.Now.AddDays(-12),11.5),
            new Venda(3,333,DateTime.Now.AddDays(-11),12.5),
            new Venda(4,444,DateTime.Now.AddDays(-10),13.5),
            new Venda(5,555,DateTime.Now.AddDays(-9),14.5),
            new Venda(6,666,DateTime.Now.AddDays(-8),15.5),
            new Venda(7,777,DateTime.Now.AddDays(-7),16.5),
            new Venda(8,888,DateTime.Now.AddDays(-6),17.5),
            new Venda(9,999,DateTime.Now.AddDays(-5),18.5),
            new Venda(10,1111,DateTime.Now.AddDays(-4),19.5),
            new Venda(11,2222,DateTime.Now.AddDays(-3),20.5),
            new Venda(12,3333,DateTime.Now.AddDays(-2),21.5),
            new Venda(13,4444,DateTime.Now.AddDays(-1),22.5),
            new Venda(14,5555,DateTime.Now,23.5)
          });

          builder.Entity<Usuario>().HasData(new List<Usuario>(){
            new Usuario(1,111,"email1@mail.com","senha1"),
            new Usuario(2,222,"email2@mail.com","senha2"),
            new Usuario(3,333,"email3@mail.com","senha3"),
            new Usuario(4,444,"email4@mail.com","senha4"),
            new Usuario(5,555,"email5@mail.com","senha5")
          });
        }
    }
}