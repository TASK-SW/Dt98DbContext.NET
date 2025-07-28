using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Oid))]
   [Table("_sptCARDS")]
   public class Cards
   {
      #region Public Constructors

       public Cards()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OID")]
       public string Oid { get; set; }

        //FK : CardTypes.Oid
        [Column("OID_TYPE")]
       public string OidType { get; set; }

        //FK : Terminals.Oid
        [Column("OID_TERMINAL")]
       public string OidTerminal { get; set; }

       [Column("ID")]
       public int Id { get; set; }

       [Column("STATE")]
       public int State { get; set; }

       [Column("RECSTATE")]
       public int RecState { get; set; }

        //FK : CardHandling.Oid
        [Column("OID_CARDHANDLING")]
       public string OidCardHandling { get; set; }

        //FK : PaymentTypes.Oid
        [Column("OID_PAYMENTTYPE")]
       public string OidPaymentType { get; set; }


       #endregion Public Properties
   }
}
