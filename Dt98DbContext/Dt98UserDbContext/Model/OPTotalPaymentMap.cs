using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptOPTOTAL_PAYMENTMAP")]
   public class OpTotalPaymentMap
   {
      #region Public Constructors

       public OpTotalPaymentMap()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
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
