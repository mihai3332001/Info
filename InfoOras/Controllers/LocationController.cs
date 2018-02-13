using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InfoOras.Models;


namespace InfoOras.Controllers
{
    public class LocationController : ApiController
    {
        private ILocationRepository _loc;
        public LocationController() : this (new LocationRepository()) { }
        public LocationController(ILocationRepository location)
        {
            _loc = location;
        }
        public IHttpActionResult Get()
        {
            IList<Locatie> loc = _loc.GetLocations();
            return Ok(loc);
        }
        public IHttpActionResult GetId(int id)
        {
           Locatie loc = _loc.GetIdLocation(id);
            if(loc == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(loc);
            }
        }
        public IHttpActionResult Post(Locatie loc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           _loc.AddLocation(loc);
            return Created(Url.Link("DefaultApi", null), _loc);
        }
        public IHttpActionResult Put(int id, Locatie loc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _loc.UpdateLocation(id, loc);
            return Ok(_loc);
        }
        public IHttpActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _loc.DeleteLocation(id);
           return StatusCode(System.Net.HttpStatusCode.NoContent);
        }
    }
}
