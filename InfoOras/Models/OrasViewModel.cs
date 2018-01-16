using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InfoOras.Models
{
 public class OrasViewModel
 {
  public int ID { get; set; }
  public int JudetID { get; set; } 

 [Required]
 [MaxLength(100, ErrorMessage ="Prea multe litere")]
  public string Oras { get; set; }

  [MaxLength(10, ErrorMessage = "Prea multe cifre")]
  public decimal? Lat { get; set; }
  [MaxLength(10, ErrorMessage ="Prea multe cifre")]
  public decimal? Long { get; set; }
  public string Judet { get; set; }

 }
}