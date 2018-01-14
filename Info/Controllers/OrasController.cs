using InfoOras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Info.Controllers
{
 public class OrasController : ApiController
 {
  DataClasses1DataContext dbmlOrase = new DataClasses1DataContext();
  
  public void Get()
  {

   return null;   
}
  public Ora Get(int id)
  {
   return null;
  }
  public void POST()
  {

  }
  public void PUT()
  {

  }
  public void Delete()
  {

  }
 }
}