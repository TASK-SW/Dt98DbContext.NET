using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("EANCODES")]
   public class EanCodes
   {
      #region Public Constructors

       public EanCodes()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("EANCODE")]
       public string EanCode { get; set; }

       [Column("OID_ARTICLE")]
       public string OidArticle { get; set; }

       [Column("SALES_PRICE")]
       public decimal SalesPrice { get; set; }


       #endregion Public Properties
   }
}
