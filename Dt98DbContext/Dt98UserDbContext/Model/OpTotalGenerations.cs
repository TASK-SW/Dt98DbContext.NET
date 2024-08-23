using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("OPTOTALGENERATIONS")]
   public class OpTotalGenerations
   {
      #region Public Constructors

       public OpTotalGenerations()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID_HOST")]
       public string OidHost { get; set; }

       [Key, Column(Order = 1)]
       //[Column("GENERATION")]
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
