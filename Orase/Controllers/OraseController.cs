﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InfoOras.Models;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Text;
using System.IO;
using System.Runtime.Remoting.Contexts;


namespace Orase.Controllers
{

 public class OraseController : ApiController
 {
  private IOrasRepository _oras;
  //public OraseController() : this(new OrasRepository()) { }
  public OraseController(IOrasRepository oras)
  {
   _oras = oras;
  }
   
  [HttpGet]
  public IHttpActionResult GetOrase()
  {
   IList<Ora> city = _oras.ListAll();
   return Ok(city);
 // IEnumerable<OraseModels> city = citiesDBML.Oras.Select(o => new OraseModels { ID = o.ID, Orase = o.Oras, Lat = o.Lat, Long = o.Long, JudetID = o.JudetID, Judet1 = o.Judet.Judet1 }).AsEnumerable();
   //return city;
   
  }
  public IHttpActionResult Get(int id)
  {
   Ora oraid = _oras.GetID(id);
   if(oraid == null)
   {
    return NotFound();
   }
   return Ok(oraid);
  }

  public IHttpActionResult Post(Ora ora) {
   if (!ModelState.IsValid)
   {
    return BadRequest(ModelState);
   }

   _oras.Add(ora);
   return Created(Url.Link("DefaultApi", new { controller = "Orase", Id = ora.ID}), ora);

  }
  public IHttpActionResult Put(int id) {
  
   return null;
  }
  public Ora Delete(int id) {
   
   return null;
  }
 }
}
