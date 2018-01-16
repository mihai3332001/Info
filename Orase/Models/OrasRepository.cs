using Orase.Controllers;
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
  public IList<Ora> ListAll(){
   List<Ora> orase =  dbmlOras.Oras.ToList();
   return orase;
  }
  public Ora GetID(int id) {
   Ora oras = dbmlOras.Oras.Where(o => o.ID == id).FirstOrDefault();
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