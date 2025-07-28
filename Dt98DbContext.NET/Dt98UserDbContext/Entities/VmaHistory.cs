using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(ProductId), nameof(VmaType), nameof(DateTime), nameof(OrderNumber))]
   [Table("VMAHISTORY")]
   public class VmaHistory
   {
      #region Public Constructors

       public VmaHistory()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("ProductId")]
       public int ProductId { get; set; }

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

       [Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }

       [Column("Volume")]
       public decimal Volume { get; set; }

       [Column("Amount")]
       public decimal Amount { get; set; }

       [Column("VolumePeriod")]
       public decimal VolumePeriod { get; set; }

       [Column("AmountPeriod")]
       public decimal AmountPeriod { get; set; }

       [Column("NewUnitPrice")]
       public decimal NewUnitPrice { get; set; }

       [Column("TSBegin")]
       public DateTime TsBegin { get; set; }

       [Column("TSPlanned")]
       public DateTime TsPlanned { get; set; }

       [Column("DeltaVolume")]
       public decimal DeltaVolume { get; set; }

       [Column("DeltaAmount")]
       public decimal DeltaAmount { get; set; }

       [Column("LastDateTime")]
       public DateTime LastDateTime { get; set; }


       #endregion Public Properties
   }
}
