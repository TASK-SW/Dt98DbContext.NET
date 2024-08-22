//==================================================================================================
//  FILE        :   TRXHISTORY.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("TRXHISTORY")]
   public class TRXHistory
   {
      #region Public Constructors

       public TRXHistory()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("APPLICATION")]
       public string Application { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("GENERATION")]
       public int Generation { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DATESTART")]
       public DateTime DateStart { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DATEEND")]
       public DateTime DateEnd { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DATEDELIVERY")]
       public DateTime DateDelivery { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DATECLEARED")]
       public DateTime DateCLEARed { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TOTAL")]
       public decimal Total { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TRANSCOUNT")]
       public int TransCount { get; set; }


       #endregion Public Properties
   }
}
