using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Orase.Models
{


 public class OraseModels
 {

  public int ID { get; set; }
 
  public int JudetID { get; set; }

  public string Orase { get; set; }

  public decimal? Lat { get; set; }

  public decimal? Long { get; set; }

  public string Judet1 { get; set; }
 }



 public partial class Ora
 {

  [DataMember]
  public int intID { get; set; }
  [DataMember]
  public int intJudetID { get; set; }
  [DataMember]
  public string intOras { get; set; }
  [DataMember]
  public string intJudet1 { get; set; }
  [DataMember]
  public Nullable<decimal> intLat { get; set; }
  [DataMember]
  public Nullable<decimal> intLong { get; set; }

  [DataMember]
  public virtual Judet intJudet { get; set; }
 }

}