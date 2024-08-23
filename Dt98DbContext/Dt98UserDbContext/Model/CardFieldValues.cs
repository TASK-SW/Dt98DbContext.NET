using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptCARDFIELDVALUES")]
   public class CardFieldValues
   {
      #region Public Constructors

       public CardFieldValues()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("OID_FIELD")]
       public string OidField { get; set; }

       [Column("VALUE")]
       public string Value { get; set; }

       [Column("CLSID")]
       public string ClsId { get; set; }

       [Column("IID")]
       public string IId { get; set; }

       [Column("INTERNALCODE")]
       public string InternalCode { get; set; }


       #endregion Public Properties
   }
}
