using InfoOras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace InfoOras.Controllers
{
 public class TransportController : ApiController
 {
  private ITransportRepository _transport;
  public TransportController() : this (new TransportRepository()) { }
  public TransportController(ITransportRepository _trans)
  {
   _transport = _trans;
  }
  public IHttpActionResult Get()
  {
   IList<Transport> _trans = _transport.TransportAll();
   return Ok(_trans);
  }
  public IHttpActionResult GetID(int id)
  {
   Transport _tran = _transport.GetTransportID(id);
   if(_tran == null)
   {
    return NotFound();
   }
   return Ok(_tran);
  }
  public IHttpActionResult Post(Transport trans)
  {
   if (!ModelState.IsValid)
   {
    return BadRequest(ModelState);
   }
   _transport.AddTransport(trans);
   return Created(Url.Link("DefaultApi", null), trans);

  }
  [HttpPut]
  public IHttpActionResult PutID(int id, Transport trans)
  {
   if (!ModelState.IsValid)
   {
    return BadRequest(ModelState);
   }
   _transport.UpdateTransport(id, trans);
   return Ok(trans);

  }
  [HttpDelete]
  public IHttpActionResult Delete(int id)
  {
   _transport.DeleteTransport(id);
   return StatusCode(System.Net.HttpStatusCode.NoContent);
  }
 }
}