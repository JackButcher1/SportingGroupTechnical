using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using SportingGroupTechnical.Models;
using SportingGroupTechnical.Services;

namespace SportingGroupTechnical.Controllers
{
    /*
     * Fixture Controller
     * ------------------
     * Controls HTTP requests for the Fixture Service, implementing the following endpoints:
     *  - GET /fixture          (gets all fixtures)
     *  - GET /fixture/{id}     (gets fixture with ID={id})
     *  - POST /fixture         (adds a new fixture)
     */
    [ApiController]
    [Route("fixture")]
    public class FixtureController : ControllerBase
    {
        /*
         * Get All
         * -------
         * Parameterless HTTP GET requests are routed here. Returns the Fixture Service's Get All method.
         */
        [HttpGet]
        public ActionResult<List<Fixture>> GetAll() => FixtureService.GetAll();

        /*
         * Get
         * ---
         * HTTP GET requests with a specified ID are routed here. Returns the Fixture Service's Get method,
         * or NotFound if null.
         */
        [HttpGet("{id}")]
        public ActionResult<Fixture> Get(Int32 id)
        {
            Fixture? fixture = FixtureService.Get(id);
            if (fixture is null)
            {
                return NotFound();
            }
            return fixture;
        }

        /*
         * Create
         * ------
         * HTTP POST requests are routed here. Passes the given Fixture into the Fixture Service's Add method,
         * then returns an HTTP created response.
         */
        [HttpPost]
        public IActionResult Create(Fixture fixture)
        {
            FixtureService.Add(fixture);
            return CreatedAtAction(nameof(Create), new { id = fixture.Id }, fixture);
        }
    }
}
