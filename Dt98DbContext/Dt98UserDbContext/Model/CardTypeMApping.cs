using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sctCARDTYPEMAPPING")]
   public class CardTypeMapping
   {
      #region Public Constructors

       public CardTypeMapping()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("TYPE_BOF")]
       public string TypeBof { get; set; }

       [Column("BOF_NAME")]
       public string BofName { get; set; }

       [Column("BOF_ID")]
       public string BofId { get; set; }


       #endregion Public Properties
   }
}
