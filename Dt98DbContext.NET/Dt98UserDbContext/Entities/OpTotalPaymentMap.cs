using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Oid))]
   [Table("_sptOPTOTAL_PAYMENTMAP")]
   public class OpTotalPaymentMap
   {
      #region Public Constructors

       public OpTotalPaymentMap()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public int Oid { get; set; }

       [Column("OID_PAYMENTTYPE")]
       public string OidPaymentType { get; set; }

       [Column("OID_TERMINALTYPE")]
       public string OidTerminalType { get; set; }

       [Column("TRANSACTION_ID")]
       public string TransactionId { get; set; }


       #endregion Public Properties
   }
}
