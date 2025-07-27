using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(TankId), nameof(ProductId), nameof(ProcessingTime), nameof(VmaSeqNumber), nameof(VmaType), nameof(VmaTypeSeqNumber), nameof(OrderNumber), nameof(TankContentsType))]
   [Table("VMA_TankContents")]
   public class VmaTankContents
   {
      #region Public Constructors

       public VmaTankContents()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("TankId")]
       public int TankId { get; set; }

       [Column("ProductId")]
       public int ProductId { get; set; }

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

       [Column("TankContentsType")]
       public int TankContentsType { get; set; }

       [Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }

       [Column("TankContents")]
       public decimal TankContents { get; set; }

       [Column("ProductLevel")]
       public decimal ProductLevel { get; set; }

       [Column("WaterLevel")]
       public decimal WaterLevel { get; set; }

       [Column("WaterVolume")]
       public decimal WaterVolume { get; set; }

       [Column("Temperature")]
       public decimal Temperature { get; set; }

       [Column("Density")]
       public decimal Density { get; set; }


       #endregion Public Properties
   }
}
