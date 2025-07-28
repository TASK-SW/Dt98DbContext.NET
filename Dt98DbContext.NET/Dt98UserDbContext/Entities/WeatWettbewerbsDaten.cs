using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Oid))]
   [Table("WEAT_WettbewerbsDaten")]
   public class WeatWettbewerbsDaten
   {
      #region Public Constructors

       public WeatWettbewerbsDaten()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OID")]
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
