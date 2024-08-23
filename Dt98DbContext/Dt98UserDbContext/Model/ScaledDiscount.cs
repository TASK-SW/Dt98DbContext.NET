using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("ScaledDiscount")]
   public class ScaledDiscount
   {
      #region Public Constructors

       public ScaledDiscount()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("ItemId")]
       public int ItemId { get; set; }

       [Key, Column(Order = 1)]
       //[Column("Threshold")]
       public decimal Threshold { get; set; }

       [Column("Type")]
       public int Type { get; set; }

       [Column("Amount")]
       public decimal Amount { get; set; }


       #endregion Public Properties
   }
}
