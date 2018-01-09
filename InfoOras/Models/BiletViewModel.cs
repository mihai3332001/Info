using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfoOras.Models
{
 public class BiletViewModel
 {
  public int ID { get; set; }

  public int? GMSID { get; set; }

  public int TransportID { get; set; }

  public decimal Pret { get; set; }

  public string Timp { get; set; }

  public string Name { get; set; }

 }
}