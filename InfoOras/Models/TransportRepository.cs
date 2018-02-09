using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfoOras.Models
{
 public class TransportRepository : ITransportRepository
 {
   DataClasses1DataContext dbmlTransport = new DataClasses1DataContext();
   public IList<Transport> TransportAll()
   {
    List<Transport> trans = dbmlTransport.Transports.ToList();
    return trans;
   }
  public Transport GetTransportID(int id)
  {
   Transport trans = dbmlTransport.Transports.Where(t => t.ID == id).FirstOrDefault();
   return trans;
  }
  public Transport AddTransport(Transport trans)
  {
   Transport newTrans = new Transport();
   newTrans.Name = trans.Name;
   newTrans.OrasID = trans.OrasID;
   dbmlTransport.Transports.InsertOnSubmit(newTrans);
   dbmlTransport.SubmitChanges();
   return newTrans;
  }
  public Transport UpdateTransport(int id, Transport trans)
  {
   Transport newTrans = dbmlTransport.Transports.Where(t => t.ID == id).FirstOrDefault();
  newTrans.Name = trans.Name;
   newTrans.OrasID = trans.OrasID;
   dbmlTransport.SubmitChanges();
   return newTrans;
  }
  public Transport DeleteTransport(int id) {
   Transport newTrans = dbmlTransport.Transports.Where(t => t.ID == id).FirstOrDefault();
   dbmlTransport.Transports.DeleteOnSubmit(newTrans);
   dbmlTransport.SubmitChanges();
   return newTrans;
  }
 }
}