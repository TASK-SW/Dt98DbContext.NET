using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("VMA_TankContents")]
   public class VmaTankContents
   {
      #region Public Constructors

       public VmaTankContents()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("TankId")]
       public int TankId { get; set; }

       [Key, Column(Order = 1)]
       //[Column("ProductId")]
       public int ProductId { get; set; }

       [Key, Column(Order = 2)]
       //[Column("ProcessingTime")]
       public DateTime ProcessingTime { get; set; }

       [Key, Column(Order = 3)]
       //[Column("VMASeqNumber")]
       public int VmaSeqNumber { get; set; }

       [Key, Column(Order = 4)]
       //[Column("VMAType")]
       public int VmaType { get; set; }

       [Key, Column(Order = 5)]
       //[Column("VMATypeSeqNumber")]
       public int VmaTypeSeqNumber { get; set; }

       [Key, Column(Order = 6)]
       //[Column("OrderNumber")]
       public int OrderNumber { get; set; }

       [Key, Column(Order = 7)]
       //[Column("TankContentsType")]
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
