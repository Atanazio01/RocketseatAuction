using Microsoft.AspNetCore.Mvc;

namespace RocketseatAuction.API.Controllers;

public class OfferController : RocketseatAuctionBaseController
{

    [HttpPost]
    public IActionResult CreateOffer()
    {
        return Created();
    }
}
