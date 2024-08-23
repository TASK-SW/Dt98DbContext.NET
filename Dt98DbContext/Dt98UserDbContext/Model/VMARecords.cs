using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("VMARECORDS")]
   public class VmaRecords
   {
      #region Public Constructors

       public VmaRecords()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("ProductId")]
       public int ProductId { get; set; }

       [Key, Column(Order = 1)]
       //[Column("FuelpointId")]
       public int FuelpointId { get; set; }

       [Key, Column(Order = 2)]
       //[Column("NozzleId")]
       public int NozzleId { get; set; }

       [Key, Column(Order = 3)]
       //[Column("TSBegin")]
       public DateTime TsBegin { get; set; }

       [Column("TSEnd")]
       public DateTime Tsend { get; set; }

       [Column("OldPrice")]
       public decimal OldPrice { get; set; }

       [Column("NewPrice")]
       public decimal NewPrice { get; set; }

       [Column("Volume")]
       public decimal Volume { get; set; }

       [Column("Amount")]
       public decimal Amount { get; set; }

       [Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }

       [Column("OrderNumber")]
       public int OrderNumber { get; set; }

       [Column("TSPlanned")]
       public DateTime TsPlanned { get; set; }


       #endregion Public Properties
   }
}
