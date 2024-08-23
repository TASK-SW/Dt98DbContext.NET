using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("VMAHISTORY_OLD")]
   public class VmaHistoryOld
   {
      #region Public Constructors

       public VmaHistoryOld()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("ProductId")]
       public int ProductId { get; set; }

       [Column("VMAType")]
       public int VmaType { get; set; }

       [Column("DateTime")]
       public DateTime DateTime { get; set; }

       [Column("UnitPrice")]
       public decimal UnitPrice { get; set; }

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

       [Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }

       [Column("OrderNumber")]
       public int OrderNumber { get; set; }

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
