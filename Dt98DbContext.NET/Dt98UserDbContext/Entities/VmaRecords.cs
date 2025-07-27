using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(ProductId), nameof(FuelpointId), nameof(NozzleId), nameof(TsBegin))]
   [Table("VMARECORDS")]
   public class VmaRecords
   {
      #region Public Constructors

       public VmaRecords()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("ProductId")]
       public int ProductId { get; set; }

       [Column("FuelpointId")]
       public int FuelpointId { get; set; }

       [Column("NozzleId")]
       public int NozzleId { get; set; }

       [Column("TSBegin")]
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
