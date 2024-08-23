using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("WEAT_WettbewerbsDaten")]
   public class WeatWettbewerbsDaten
   {
      #region Public Constructors

       public WeatWettbewerbsDaten()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("OID_WETTBEWERBER")]
       public string OidWettBewerber { get; set; }

       [Column("ProductId")]
       public int ProductId { get; set; }

       [Column("UnitPrice")]
       public decimal UnitPrice { get; set; }

       [Column("DateTime")]
       public DateTime DateTime { get; set; }


       #endregion Public Properties
   }
}
