using Leilao.API.Contracts;
using Leilao.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Leilao.API.Repositories.DataAccess;

public class AuctionRepository : IAuctionRepository
{
    private readonly APILeilaoDbContext _dbcontext;

    public AuctionRepository(APILeilaoDbContext dbcontext) => _dbcontext = dbcontext;

    public Auction? GetCurrent()
    {
        var today = DateTime.Now;

        return _dbcontext
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}
