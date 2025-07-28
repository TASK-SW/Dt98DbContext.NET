using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Oid))]
   [Table("_sptNOZZLES")]
   public class Nozzles
   {
      #region Public Constructors

       public Nozzles()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OID")]
       public string Oid { get; set; }

        //FK : NozzleTypes.Oid
        [Column("OID_TYPE")]
       public string OidType { get; set; }

        //FK : FuelIngPoints.Oid
        [Column("OID_FUELINGPOINT")]
       public string OidFuelIngPoint { get; set; }

        //FK : Tanks.Oid
        [Column("OID_TANK")]
       public string OidTank { get; set; }

       [Column("ID")]
       public int Id { get; set; }


       #endregion Public Properties
   }
}
