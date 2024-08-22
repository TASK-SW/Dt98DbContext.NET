//==================================================================================================
//  FILE        :   TRXDATA.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("TRXDATA")]
   public class TRXData
   {
      #region Public Constructors

       public TRXData()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_TRX")]
       public string OidTRX { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("GENERATION")]
       public int Generation { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_SEQUENCE")]
       public int DTSequence { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_TOTALAMOUNT")]
       public decimal DTTotalAmount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_DATE")]
       public DateTime DTDate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_JOURHEAD")]
       public string DTJourHead { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_TRANSACT")]
       public string DTTransACT { get; set; }


       #endregion Public Properties
   }
}
