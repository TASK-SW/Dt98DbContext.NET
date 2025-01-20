using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("VMA_FuelSales")]
   public class VmaFuelSales
   {
      #region Public Constructors

       public VmaFuelSales()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("EntryTime")]
       public DateTime EntryTime { get; set; }

       [Column("AuthorizationTime")]
       public DateTime AuthorizationTime { get; set; }

       [Column("FuelStartTime")]
       public DateTime FuelStartTime { get; set; }

       [Column("FuelEndTime")]
       public DateTime FuelEndTime { get; set; }

       [Column("TerminalId")]
       public string TerminalId { get; set; }

       [Column("PaymentType")]
       public string PaymentType { get; set; }

       [Column("ProductId")]
       public int ProductId { get; set; }

       [Column("FuelPointId")]
       public int FuelPointId { get; set; }

       [Column("NozzleId")]
       public int NozzleId { get; set; }

       [Column("Amount")]
       public decimal Amount { get; set; }

       [Column("Volume")]
       public decimal Volume { get; set; }

       [Column("UnitPrice")]
       public decimal UnitPrice { get; set; }

       [Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }


       #endregion Public Properties
   }
}
