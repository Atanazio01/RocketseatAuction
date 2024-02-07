using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; } = default!;
    public DbSet<User> Users { get; set; } = default!;
    public DbSet<Offer> Offers { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Workspace\\Rocketseat\\nlw-expert\\leilaoDbNLW.db");
    }
}
