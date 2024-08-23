using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptPRODUCTCODETAXMAP")]
   public class ProductCodeTaxMap
   {
      #region Public Constructors

       public ProductCodeTaxMap()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("ID")]
       public int Id { get; set; }

       [Key, Column(Order = 1)]
       //[Column("EXTCODE")]
       public int ExtCode { get; set; }

       [Column("VAT_OID")]
       public string VatOid { get; set; }

       [Column("PRODUCTCODENAME")]
       public string ProductCodeName { get; set; }


       #endregion Public Properties
   }
}
