using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Oid))]
   [Table("_sptFUELINGPOINTS")]
   public class FuelIngPoints
   {
      #region Public Constructors

       public FuelIngPoints()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OID")]
       public string Oid { get; set; }

        //FK : FuelIngPointTypes.Oid
        [Column("OID_TYPE")]
       public string OidType { get; set; }

        //FK : Pumps.Oid
        [Column("OID_PUMP")]
       public string OidPump { get; set; }

       [Column("ID")]
       public int Id { get; set; }

       [Column("EXTERNNUMBER")]
       public int ExternNumber { get; set; }


       #endregion Public Properties
   }
}
