using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptOPTOTAL_PRODUCTMAP")]
   public class OpTotalProductMap
   {
      #region Public Constructors

       public OpTotalProductMap()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public int Oid { get; set; }

       [Column("ARTICLE_ID")]
       public string ArticleId { get; set; }

       [Column("PRODUCT_ID")]
       public string ProductId { get; set; }


       #endregion Public Properties
   }
}
