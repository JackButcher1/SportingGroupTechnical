using Microsoft.AspNetCore.Mvc;
using System;
using SportingGroupTechnical.Models;
using SportingGroupTechnical.Services;

namespace SportingGroupTechnical.Controllers
{
    /*
     * Betting Controller
     * ------------------
     * Controls HTTP requests for the Betting Service, implementing the following endpoints:
     *  - GET /bet/{id}     (gets bet with ID={id})
     *  - POST /bet         (adds a new bet)
     */
    [ApiController]
    [Route("bet")]
    public class BettingController : ControllerBase
    {
        /*
         * Get
         * ---
         * HTTP GET requests with a specified ID are routed here. Returns the Betting Service's Get method,
         * or NotFound if null.
         */
        [HttpGet("{id}")]
        public ActionResult<Bet> Get(Int32 id)
        {
            Bet? bet = BettingService.Get(id);
            if (bet is null)
            {
                return NotFound();
            }
            return bet;
        }

        /*
         * Create
         * ------
         * HTTP POST requests are routed here. Passes the given Bet into the Betting Service's Add method,
         * then returns an HTTP created response.
         */
        [HttpPost]
        public IActionResult Create(Bet bet)
        {
            if (BettingService.Add(bet) == -1)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(Create), new { id = bet.Id }, bet);
        }
    }
}
