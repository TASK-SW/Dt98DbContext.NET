using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Id), nameof(ExtCode))]
   [Table("_sptPRODUCTCODETAXMAP")]
   public class ProductCodeTaxMap
   {
      #region Public Constructors

       public ProductCodeTaxMap()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("ID")]
       public int Id { get; set; }

       [Column("EXTCODE")]
       public int ExtCode { get; set; }

       [Column("VAT_OID")]
       public string VatOid { get; set; }

       [Column("PRODUCTCODENAME")]
       public string ProductCodeName { get; set; }


       #endregion Public Properties
   }
}
