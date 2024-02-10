using Leilao.API.Comunication.Requests;
using Leilao.API.Filters;
using Leilao.API.UseCases.Offers.CreateOffer;
using Microsoft.AspNetCore.Mvc;

namespace Leilao.API.Controllers;

[ServiceFilter(typeof(AuthentictionUserAttribute))]
public class OfferController : LeilaoApiBaseController
{

    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer(
        [FromRoute] int itemId,
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);

        return Created(String.Empty, id);
    }

}
