using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("MTS")]
   public class MTs
   {
      #region Public Constructors

       public MTs()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("ProductSign")]
       public string ProductSign { get; set; }

       [Column("ProductCode")]
       public int ProductCode { get; set; }

       [Column("NewPrice")]
       public decimal NewPrice { get; set; }

       [Column("OldPrice")]
       public decimal OldPrice { get; set; }

       [Column("ServiceMode")]
       public int ServiceMode { get; set; }

       [Column("DateTime")]
       public DateTime DateTime { get; set; }

       [Column("OrderNumber")]
       public int OrderNumber { get; set; }

       [Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }


       #endregion Public Properties
   }
}
