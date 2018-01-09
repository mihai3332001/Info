using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfoOras.Models
{
 public class OrasViewModel
 {
  public int ID { get; set; }
  public int JudetID { get; set; } 
  public string Oras { get; set; }
  public decimal? Lat { get; set; }
  public decimal? Long { get; set; }
  public string Judet { get; set; }
 }
}