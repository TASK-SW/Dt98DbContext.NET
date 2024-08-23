using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("ArticleStock")]
   public class ArticleStock
   {
      #region Public Constructors

       public ArticleStock()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OIDArticle")]
       public string OidArticle { get; set; }

       [Key, Column(Order = 1)]
       //[Column("WorkstationId")]
       public int WorkstationId { get; set; }

       [Column("CurrentQuantity")]
       public decimal CurrentQuantity { get; set; }

       [Column("OpenQuantity")]
       public decimal OpenQuantity { get; set; }


       #endregion Public Properties
   }
}
