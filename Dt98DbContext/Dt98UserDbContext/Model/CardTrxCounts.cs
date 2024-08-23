using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptCARDTRXCOUNTS")]
   public class CardTrxCounts
   {
      #region Public Constructors

       public CardTrxCounts()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("OID_TYPE")]
       public string OidType { get; set; }

       [Column("ID")]
       public int Id { get; set; }

       [Column("RESETDATE")]
       public DateTime ResetDate { get; set; }


       #endregion Public Properties
   }
}
