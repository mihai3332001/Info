using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiOrase.Models
{
 public class oraseModel
 {

   public int ID { get; set; }

   public int JudetID { get; set; }

   public string Orase { get; set; }

   public decimal? Lat { get; set; }

   public decimal? Long { get; set; }

   public string Judet1 { get; set; }

 }
}