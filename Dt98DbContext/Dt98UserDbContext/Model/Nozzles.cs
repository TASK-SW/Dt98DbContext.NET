using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptNOZZLES")]
   public class Nozzles
   {
      #region Public Constructors

       public Nozzles()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("OID_TYPE")]
       public string OidType { get; set; }

       [Column("OID_FUELINGPOINT")]
       public string OidFuelIngPoint { get; set; }

       [Column("OID_TANK")]
       public string OidTank { get; set; }

       [Column("ID")]
       public int Id { get; set; }


       #endregion Public Properties
   }
}
