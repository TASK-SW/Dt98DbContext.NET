using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(ProductId), nameof(FuelPointId), nameof(NozzleId), nameof(TankId), nameof(ProcessingTime), nameof(VmaSeqNumber), nameof(VmaType), nameof(VmaTypeSeqNumber), nameof(OrderNumber))]
   [Table("VMA_History")]
   public class Vma_History
   {
      #region Public Constructors

       public Vma_History()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("ProductId")]
       public int ProductId { get; set; }

       [Column("FuelPointId")]
       public int FuelPointId { get; set; }

       [Column("NozzleId")]
       public int NozzleId { get; set; }

       [Column("TankId")]
       public int TankId { get; set; }

       [Column("ProcessingTime")]
       public DateTime ProcessingTime { get; set; }

       [Column("VMASeqNumber")]
       public int VmaSeqNumber { get; set; }

       [Column("VMAType")]
       public int VmaType { get; set; }

       [Column("VMATypeSeqNumber")]
       public int VmaTypeSeqNumber { get; set; }

       [Column("OrderNumber")]
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
