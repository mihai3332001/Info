using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InfoOras.Models;

namespace Orase.Controllers
{
 public interface IOrasRepository
 {
  IList<Ora> ListAll();
  Ora GetID(int id);
  Ora Add(Ora ora);
 }
}