using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("TankTransactions")]
   public class TankTransactions
   {
      #region Public Constructors

       public TankTransactions()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("PkId")]
       public string PkId { get; set; }

       [Column("TrxDate")]
       public DateTime TrxDate { get; set; }

       [Column("TrxType")]
       public int TrxType { get; set; }

       [Column("TankId")]
       public int TankId { get; set; }

       [Column("ProductId")]
       public int ProductId { get; set; }

       [Column("Quantity")]
       public decimal Quantity { get; set; }

       [Column("Info")]
       public string Info { get; set; }


       #endregion Public Properties
   }
}
