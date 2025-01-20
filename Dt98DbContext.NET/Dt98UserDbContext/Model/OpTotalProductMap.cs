using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("_sptOPTOTAL_PRODUCTMAP")]
   public class OpTotalProductMap
   {
      #region Public Constructors

       public OpTotalProductMap()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public int Oid { get; set; }

       [Column("ARTICLE_ID")]
       public string ArticleId { get; set; }

       [Column("PRODUCT_ID")]
       public string ProductId { get; set; }


       #endregion Public Properties
   }
}
