using InfoOras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfoOras.Models
{
 public class OrasRepository : IOrasRepository
 {
  private DataClasses1DataContext dbmlOras;

  public OrasRepository()
  {
   dbmlOras = new DataClasses1DataContext();
  }
  public IList<OrasViewModel> ListAll(){
   List<OrasViewModel> orase = dbmlOras.Oras.Select(o => new OrasViewModel { ID = o.ID, Judet = o.Judet.Judet1, Oras = o.Oras, JudetID = o.JudetID, Lat = o.Lat, Long = o.Long }).ToList();
   return orase;
  }
  public Ora GetID(int id) {
   Ora oras = dbmlOras.Oras.Where(o => o.ID == id).FirstOrDefault();
   return oras;
  }

  public Ora Update(int id)
  {
   Ora oras = dbmlOras.Oras.Where(o => o.ID == id).FirstOrDefault();
   Ora ora = new Ora();
   ora.ID = oras.ID;
   ora.Oras = oras.Oras;
   ora.Lat = oras.Lat;
   ora.Long = oras.Long;
   ora.JudetID = oras.JudetID;
   dbmlOras.SubmitChanges();
   return oras;
  }

  public Ora Delete(int id)
  {
   Ora oras = dbmlOras.Oras.Where(o => o.ID == id).FirstOrDefault();
   Ora ora = new Ora();
   ora.ID = oras.ID;
   dbmlOras.Oras.DeleteOnSubmit(ora);
   return oras;
  }

  public Ora Add(Ora oras) {
   Ora ora = new Ora();
   ora.Oras = oras.Oras;
   ora.Lat = oras.Lat;
   ora.Long = oras.Long;
   ora.JudetID = oras.JudetID;
   dbmlOras.Oras.InsertOnSubmit(ora);
   dbmlOras.SubmitChanges();
   //dbmlOras.Oras.Where(x => x.Oras == oras.Oras).FirstOrDefault();
   return oras;
  }
 
 }
}