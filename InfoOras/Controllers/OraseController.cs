﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InfoOras.Models;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Text;
using System.IO;
using System.Runtime.Remoting.Contexts;
using InfoOras.DTO;

namespace InfoOras.Controllers
{

 public class OraseController : ApiController
 {
  private IOrasRepository _oras;
  public OraseController() : this(new OrasRepository()) { }
  public OraseController(IOrasRepository oras)
  {
   _oras = oras;
  }

  [HttpGet]
  public IHttpActionResult GetOrase()
  {
   IList<OrasViewModel> city = _oras.ListAll();
   return Ok(city);
  }
  [HttpGet]
  public IHttpActionResult Get(int id)
  {
   Ora oraid = _oras.GetID(id);
   if (oraid == null)
   {
    return NotFound();
   }
   return Ok(oraid);
  }
  [HttpPost]
  public IHttpActionResult Post(EntryDto ora) {
   if (!ModelState.IsValid)
   {
    return BadRequest(ModelState);
   }
   Ora or = ora.toModel();
  
   _oras.Add(or);
   or.ID = ora.ID;
   return Created(Url.Link("DefaultApi", null), ora);

  }
  [HttpPut]
  public IHttpActionResult PutID(int id, Ora ora) {
  Ora oras = _oras.Update(id);
   return StatusCode(System.Net.HttpStatusCode.NoContent);
  }
  [HttpDelete]
  public IHttpActionResult Delete(int id) {
   Ora oraDelete = _oras.Delete(id);
   return Ok(oraDelete);
  }
 }
}