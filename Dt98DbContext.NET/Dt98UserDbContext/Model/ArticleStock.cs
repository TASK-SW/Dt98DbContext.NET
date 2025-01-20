using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(OidArticle), nameof(WorkstationId))]
   [Table("ArticleStock")]
   public class ArticleStock
   {
      #region Public Constructors

       public ArticleStock()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OIDArticle")]
       public string OidArticle { get; set; }

       [Column("WorkstationId")]
       public int WorkstationId { get; set; }

       [Column("CurrentQuantity")]
       public decimal CurrentQuantity { get; set; }

       [Column("OpenQuantity")]
       public decimal OpenQuantity { get; set; }


       #endregion Public Properties
   }
}
