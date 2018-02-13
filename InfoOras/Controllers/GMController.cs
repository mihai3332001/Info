using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InfoOras.Models;
using System.Web.Http;

namespace InfoOras.Controllers
{
    public class GMController : ApiController
    {
        private IGMSRepository _gms;
        public GMController() : this(new GMSRepository()) { }
        public GMController(IGMSRepository GMS)
        {
            _gms = GMS;
        }
        public IHttpActionResult Get()
        {
            IList<GM> gm = _gms.GMSALL();
            return Ok(gm);
        }

        public IHttpActionResult GEtID(int id)
        {
            GM gmID = _gms.GetGms(id);
            if(gmID == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(gmID);
            }
            
        }
        public IHttpActionResult Post(GM gm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _gms.AddGms(gm);
            return Created(Url.Link("DefaultApi", null), _gms);
        }
        public IHttpActionResult Put(int id, GM gm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _gms.UpdateGM(id, gm);
            return Ok(_gms);
        }
        public IHttpActionResult Delete(int id)
        {
            _gms.DeleteGM(id);
            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }
    }
}