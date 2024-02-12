using Leilao.API.Contracts;
using Leilao.API.Entities;

namespace Leilao.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionsUseCase
{
    private readonly IAuctionRepository _repository;

    public GetCurrentAuctionsUseCase(IAuctionRepository repository) => _repository = repository;

    public Auction? Execute()
    {
        return _repository.GetCurrent();        
    }
}
