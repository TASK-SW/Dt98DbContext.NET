using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(OidJourHead))]
   [Table("ReceiptsToPrint")]
   public class ReceiptsToPrint
   {
      #region Public Constructors

       public ReceiptsToPrint()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID_JourHead")]
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
