//==================================================================================================
//  FILE        :   ReceiptsToPrint.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("ReceiptsToPrint")]
   public class ReceiptsToPrint
   {
      #region Public Constructors

       public ReceiptsToPrint()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_JourHead")]
       public string OidJourHead { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TerminalId")]
       public string TerminalId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ReceiptMsg")]
       public string ReceiptMsg { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("RetryPrintCount")]
       public int RetryPrintCount { get; set; }


       #endregion Public Properties
   }
}
