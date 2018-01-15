using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiOrase.Models;

namespace ApiOrase.Controllers
{
    public class OraseController : ApiController
    {
        // GET: api/Orase
        public IEnumerable<oraseModel> Get()
        {
         apiDbmlDataContext citiesDBML = new apiDbmlDataContext();
   IEnumerable<oraseModel> city = citiesDBML.Oras.Select(o => new oraseModel { ID = o.ID, Orase = o.Oras, Lat = o.Lat, Long = o.Long, JudetID = o.JudetID, Judet1 = o.Judet.Judet1 }).AsEnumerable();
   return city;
  }

        // GET: api/Orase/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Orase
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Orase/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Orase/5
        public void Delete(int id)
        {
        }
    }
}
