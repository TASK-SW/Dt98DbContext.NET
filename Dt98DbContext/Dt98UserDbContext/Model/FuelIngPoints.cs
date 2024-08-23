using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptFUELINGPOINTS")]
   public class FuelIngPoints
   {
      #region Public Constructors

       public FuelIngPoints()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("OID_TYPE")]
       public string OidType { get; set; }

       [Column("OID_PUMP")]
       public string OidPump { get; set; }

       [Column("ID")]
       public int Id { get; set; }

       [Column("EXTERNNUMBER")]
       public int ExternNumber { get; set; }


       #endregion Public Properties
   }
}
