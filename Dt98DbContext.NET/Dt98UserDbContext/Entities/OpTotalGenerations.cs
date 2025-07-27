using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(OidHost), nameof(Generation))]
   [Table("OPTOTALGENERATIONS")]
   public class OpTotalGenerations
   {
      #region Public Constructors

       public OpTotalGenerations()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID_HOST")]
       public string OidHost { get; set; }

       [Column("GENERATION")]
       public int Generation { get; set; }

       [Column("CYCLESTART")]
       public DateTime CycleStart { get; set; }

       [Column("CYCLEEND")]
       public DateTime CycleEnd { get; set; }

       [Column("CREATIONSTART")]
       public DateTime CreationStart { get; set; }

       [Column("CREATIONEND")]
       public DateTime CreationEnd { get; set; }

       [Column("DELIVERYDATE")]
       public DateTime DeliveryDate { get; set; }


       #endregion Public Properties
   }
}
