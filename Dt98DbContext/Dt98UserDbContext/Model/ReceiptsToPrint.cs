using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("ReceiptsToPrint")]
   public class ReceiptsToPrint
   {
      #region Public Constructors

       public ReceiptsToPrint()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID_JourHead")]
       public string OidJourHead { get; set; }

       [Column("TerminalId")]
       public string TerminalId { get; set; }

       [Column("ReceiptMsg")]
       public string ReceiptMsg { get; set; }

       [Column("RetryPrintCount")]
       public int RetryPrintCount { get; set; }


       #endregion Public Properties
   }
}
