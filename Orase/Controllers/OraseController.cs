using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Orase.Models;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Text;
using System.IO;

namespace Orase.Controllers
{

 public class OraseController : ApiController
 {

  CtiesDBMLDataContext citiesDBML = new CtiesDBMLDataContext();
  List<OraseModels> orasVM = new List<OraseModels>();

  [HttpGet]
  public IEnumerable<OraseModels> GetOrase()
  {
  IEnumerable<OraseModels> city = citiesDBML.Oras.Select(o => new OraseModels { ID = o.ID, Orase = o.Oras, Lat = o.Lat, Long = o.Long, JudetID = o.JudetID, Judet1 = o.Judet.Judet1 }).AsEnumerable();
   return city;
  }
  public OraseModels Get(int id) {
   return null;
  }

 }
}
