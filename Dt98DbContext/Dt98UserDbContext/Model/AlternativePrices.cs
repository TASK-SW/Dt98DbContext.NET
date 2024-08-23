using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("AlternativePrices")]
   public class AlternativePrices
   {
      #region Public Constructors

       public AlternativePrices()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OIDArticle")]
       public string OidArticle { get; set; }

       [Key, Column(Order = 1)]
       //[Column("PriceId")]
       public int PriceId { get; set; }

       [Column("SalesPrice")]
       public decimal SalesPrice { get; set; }


       #endregion Public Properties
   }
}
