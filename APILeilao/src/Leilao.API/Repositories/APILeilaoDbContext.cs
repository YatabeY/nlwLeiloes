using Leilao.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Leilao.API.Repositories;

public class APILeilaoDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }

    //Onde ta o banco de dados
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=‪D:\APIleilao\leilaoDbNLW.db");
    }
}
