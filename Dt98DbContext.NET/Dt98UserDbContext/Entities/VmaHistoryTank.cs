using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(ProductId), nameof(TankId), nameof(VmaType), nameof(DateTime), nameof(OrderNumber))]
   [Table("VMAHISTORYTANK")]
   public class VmaHistoryTank
   {
      #region Public Constructors

       public VmaHistoryTank()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("ProductId")]
       public int ProductId { get; set; }

        [Key]
        [Column("TankId")]
       public int TankId { get; set; }

        [Key]
        [Column("VMAType")]
       public int VmaType { get; set; }

        [Key]
        [Column("DateTime")]
       public DateTime DateTime { get; set; }

        [Key]
        [Column("OrderNumber")]
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
