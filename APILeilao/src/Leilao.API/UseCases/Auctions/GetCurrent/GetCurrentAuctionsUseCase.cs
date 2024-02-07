using Leilao.API.Entities;
using Leilao.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Leilao.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionsUseCase
{
    public Auction? Execute()
    {
        var repository = new APILeilaoDbContext();

        var today = DateTime.Now;

        return repository
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}
