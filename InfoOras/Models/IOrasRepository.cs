using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InfoOras.Models;

namespace InfoOras.Models
{
 public interface IOrasRepository
 {
  IList<OrasViewModel> ListAll();
  Ora GetID(int id);
  Ora Add(Ora ora);
  Ora Update(int id, Ora ora);
  Ora Delete(int id);
 }
}