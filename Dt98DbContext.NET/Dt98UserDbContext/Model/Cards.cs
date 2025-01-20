using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("_sptCARDS")]
   public class Cards
   {
      #region Public Constructors

       public Cards()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("OID_TYPE")]
       public string OidType { get; set; }

       [Column("OID_TERMINAL")]
       public string OidTerminal { get; set; }

       [Column("ID")]
       public int Id { get; set; }

       [Column("STATE")]
       public int State { get; set; }

       [Column("RECSTATE")]
       public int RecState { get; set; }

       [Column("OID_CARDHANDLING")]
       public string OidCardHandling { get; set; }

       [Column("OID_PAYMENTTYPE")]
       public string OidPaymentType { get; set; }


       #endregion Public Properties
   }
}
