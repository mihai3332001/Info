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
  public OraseController()
  {
   
  }
  [HttpGet]
  public List<OraseModels> GetOrase()
  {

   orasVM = citiesDBML.Oras.Select(o => new OraseModels { ID = o.intID, Orase = o.intOras, Lat = o.intLat, Long = o.intLong, JudetID = o.intJudetID, Judet1 = o.intJudet1 }).ToList();
   return orasVM;
  }
  }
}
