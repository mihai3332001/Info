using InfoOras.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InfoOras.DTO
{
 public class EntryDto
 {

  public int ID { get; set; }

  [Required]
  public int JudetID { get; set; }

  [Required]
  public string Oras { get; set; }

  public decimal? Lat { get; set; }

  public decimal? Long { get; set; }

  public Ora toModel()
  {
   return new Ora()
   {
    ID = ID,
    Oras = Oras,
    JudetID = JudetID,
    Lat = Lat,
    Long = Long

   };
  }
 }
}