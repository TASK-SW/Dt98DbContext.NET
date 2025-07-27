using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(ItemId), nameof(Threshold))]
   [Table("ScaledDiscount")]
   public class ScaledDiscount
   {
      #region Public Constructors

       public ScaledDiscount()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("ItemId")]
       public int ItemId { get; set; }

       [Column("Threshold")]
       public decimal Threshold { get; set; }

       [Column("Type")]
       public int Type { get; set; }

       [Column("Amount")]
       public decimal Amount { get; set; }


       #endregion Public Properties
   }
}
