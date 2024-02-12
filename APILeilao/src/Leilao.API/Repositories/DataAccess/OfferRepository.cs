using Leilao.API.Contracts;
using Leilao.API.Entities;
using Leilao.API.Services;

namespace Leilao.API.Repositories.DataAccess;

public class OfferRepository : IOfferRepository
{
    private readonly APILeilaoDbContext _dbcontext;

    public OfferRepository(APILeilaoDbContext dbcontext) => _dbcontext = dbcontext;

    public void Add(Offer offer)
    {
        _dbcontext.Offers.Add(offer);

        _dbcontext.SaveChanges();
    }
}
