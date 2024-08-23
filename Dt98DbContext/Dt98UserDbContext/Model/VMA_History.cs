using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("VMA_History")]
   public class VMA_History
   {
      #region Public Constructors

       public VMA_History()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("ProductId")]
       public int ProductId { get; set; }

       [Key, Column(Order = 1)]
       //[Column("FuelPointId")]
       public int FuelPointId { get; set; }

       [Key, Column(Order = 2)]
       //[Column("NozzleId")]
       public int NozzleId { get; set; }

       [Key, Column(Order = 3)]
       //[Column("TankId")]
       public int TankId { get; set; }

       [Key, Column(Order = 4)]
       //[Column("ProcessingTime")]
       public DateTime ProcessingTime { get; set; }

       [Key, Column(Order = 5)]
       //[Column("VMASeqNumber")]
       public int VmaSeqNumber { get; set; }

       [Key, Column(Order = 6)]
       //[Column("VMAType")]
       public int VmaType { get; set; }

       [Key, Column(Order = 7)]
       //[Column("VMATypeSeqNumber")]
       public int VmaTypeSeqNumber { get; set; }

       [Key, Column(Order = 8)]
       //[Column("OrderNumber")]
       public int OrderNumber { get; set; }

       [Column("Status")]
       public int Status { get; set; }

       [Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }

       [Column("PlannedTime")]
       public DateTime PlannedTime { get; set; }

       [Column("UnitPrice")]
       public decimal UnitPrice { get; set; }

       [Column("NewUnitPrice")]
       public decimal NewUnitPrice { get; set; }

       [Column("Volume")]
       public decimal Volume { get; set; }

       [Column("Amount")]
       public decimal Amount { get; set; }

       [Column("ResultCode")]
       public int ResultCode { get; set; }


       #endregion Public Properties
   }
}
