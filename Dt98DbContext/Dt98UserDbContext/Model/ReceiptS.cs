//==================================================================================================
//  FILE        :   RECEIPTS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("RECEIPTS")]
   public class ReceiptS
   {
      #region Public Constructors

       public ReceiptS()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_CARDTYPE")]
       public string OidCardType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_TERMINAL")]
       public string OidTerminal { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TERMINALTYPE")]
       public int TerminalType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PAN")]
       public string PAN { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PRINTCOUNT")]
       public int PrintCount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DATESTORE")]
       public DateTime DateStore { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DATEPRINT")]
       public DateTime DatePrint { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("RECEIPTTEXT")]
       public string ReceiptText { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("EXTRADATA")]
       public string ExtraData { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PRINTER_WIDTH")]
       public int PrinterWidth { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("WM_FORMAT")]
       public string WMFormat { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PAN2")]
       public string PAN2 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PAN3")]
       public string PAN3 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PAN4")]
       public string PAN4 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PAN5")]
       public string PAN5 { get; set; }


       #endregion Public Properties
   }
}
