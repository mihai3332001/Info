﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIOras.Controllers
{
    public class CitiesController : ApiController
    {
        // GET: api/Cities
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cities/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cities
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cities/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cities/5
        public void Delete(int id)
        {
        }
    }
}
