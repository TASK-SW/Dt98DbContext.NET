using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptCARDFIELDS")]
   public class CardFields
   {
      #region Public Constructors

       public CardFields()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("OID_TYPE")]
       public string OidType { get; set; }

       [Column("FIELDID")]
       public int FieldId { get; set; }

       [Column("POSITION")]
       public int Position { get; set; }

       [Column("LENGTH")]
       public int Length { get; set; }

       [Column("CHECKOPTION")]
       public int CheckOption { get; set; }

       [Column("MINSIZE")]
       public int MinSize { get; set; }

       [Column("MAXSIZE")]
       public int MaxSize { get; set; }

       [Column("TEXTID")]
       public int TextId { get; set; }


       #endregion Public Properties
   }
}
