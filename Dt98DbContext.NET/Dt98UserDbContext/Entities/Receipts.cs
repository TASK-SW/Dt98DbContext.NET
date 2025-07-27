using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Oid))]
   [Table("RECEIPTS")]
   public class Receipts
   {
      #region Public Constructors

       public Receipts()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("OID_CARDTYPE")]
       public string OidCardType { get; set; }

       [Column("OID_TERMINAL")]
       public string OidTerminal { get; set; }

       [Column("TERMINALTYPE")]
       public int TerminalType { get; set; }

       [Column("PAN")]
       public string Pan { get; set; }

       [Column("PRINTCOUNT")]
       public int PrintCount { get; set; }

       [Column("DATESTORE")]
       public DateTime DateStore { get; set; }

       [Column("DATEPRINT")]
       public DateTime DatePrint { get; set; }

       [Column("RECEIPTTEXT")]
       public string ReceiptText { get; set; }

       [Column("EXTRADATA")]
       public string ExtraData { get; set; }

       [Column("PRINTER_WIDTH")]
       public int PrinterWidth { get; set; }

       [Column("WM_FORMAT")]
       public string WmFormat { get; set; }

       [Column("PAN2")]
       public string Pan2 { get; set; }

       [Column("PAN3")]
       public string Pan3 { get; set; }

       [Column("PAN4")]
       public string Pan4 { get; set; }

       [Column("PAN5")]
       public string Pan5 { get; set; }


       #endregion Public Properties
   }
}
