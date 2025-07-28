using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Oid))]
   [Table("_sptCARDFIELDVALUES")]
   public class CardFieldValues
   {
      #region Public Constructors

       public CardFieldValues()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OID")]
       public string Oid { get; set; }

        //FK : CardFields.Oid
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
