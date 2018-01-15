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
using System.Runtime.Remoting.Contexts;

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
  public Ora Get(int id)
  {
   Ora cityID = citiesDBML.Oras.Where(o => o.ID == id).FirstOrDefault();
   if(cityID == null)
   {
    return null;
   }
   return cityID;
  }
  [HttpPost]
  public Ora Post(Ora ora) {
   ora.Oras = ora.Oras;

   return ora;
  }
  public Ora Put(int id) {
   Ora cityID = citiesDBML.Oras.Where(o => o.ID == id).FirstOrDefault();
   citiesDBML.SubmitChanges();

   return cityID;
  }
  public Ora Delete(int id) {
   Ora cityID = citiesDBML.Oras.Where(o => o.ID == id).FirstOrDefault();
   return cityID;
  }
 }
}
