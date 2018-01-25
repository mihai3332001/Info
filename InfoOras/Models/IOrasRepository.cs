using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InfoOras.Models;

namespace InfoOras.Models
{
 public interface IOrasRepository
 {
  IList<Ora> ListAll();
  Ora GetID(int id);
  Ora Add(Ora ora);
  Ora Update(int id, Ora ora);
  Ora Delete(int id);
 }

 public interface ITransportRepository {
  IList<Transport> TransportAll();
  Transport GetTransportID(int id);
  Transport AddTransport(Transport trans);
  Transport UpdateTransport(int id, Transport name);
  //Transport Delete(int id);
 }
}