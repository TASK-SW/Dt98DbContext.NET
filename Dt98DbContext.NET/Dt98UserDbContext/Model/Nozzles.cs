using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("_sptNOZZLES")]
   public class Nozzles
   {
      #region Public Constructors

       public Nozzles()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
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
