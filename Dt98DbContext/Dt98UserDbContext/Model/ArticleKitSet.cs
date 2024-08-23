using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("ARTICLEKITSET")]
   public class ArticleKitSet
   {
      #region Public Constructors

       public ArticleKitSet()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID_PARENT")]
       public string OidParent { get; set; }

       [Key, Column(Order = 1)]
       //[Column("OID_CHILD")]
       public string OidChild { get; set; }

       [Column("COUNT")]
       public int Count { get; set; }


       #endregion Public Properties
   }
}
