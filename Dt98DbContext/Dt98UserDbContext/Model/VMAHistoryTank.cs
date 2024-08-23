using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("VMAHISTORYTANK")]
   public class VmaHistoryTank
   {
      #region Public Constructors

       public VmaHistoryTank()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("ProductId")]
       public int ProductId { get; set; }

       [Key, Column(Order = 1)]
       //[Column("TankId")]
       public int TankId { get; set; }

       [Key, Column(Order = 2)]
       //[Column("VMAType")]
       public int VmaType { get; set; }

       [Key, Column(Order = 3)]
       //[Column("DateTime")]
       public DateTime DateTime { get; set; }

       [Key, Column(Order = 4)]
       //[Column("OrderNumber")]
       public int OrderNumber { get; set; }

       [Column("UnitPrice")]
       public decimal UnitPrice { get; set; }

       [Column("UnitPriceNew")]
       public decimal UnitPriceNew { get; set; }

       [Column("TankContent")]
       public decimal TankContent { get; set; }

       [Column("TankMeter")]
       public decimal TankMeter { get; set; }

       [Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }


       #endregion Public Properties
   }
}
