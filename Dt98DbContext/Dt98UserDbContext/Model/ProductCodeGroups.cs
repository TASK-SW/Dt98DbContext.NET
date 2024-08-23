using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptPRODUCTCODEGROUPS")]
   public class ProductCodeGroups
   {
      #region Public Constructors

       public ProductCodeGroups()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("ID")]
       public int Id { get; set; }

       [Column("DESCRIPTION")]
       public string Description { get; set; }

       [Column("FIXED_VAT")]
       public int FixedVat { get; set; }


       #endregion Public Properties
   }
}
