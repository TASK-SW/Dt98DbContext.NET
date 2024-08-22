//==================================================================================================
//  FILE        :   JOURNALCURRENCY.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("JOURNALCURRENCY")]
   public class JournalCurrency
   {
      #region Public Constructors

       public JournalCurrency()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_JOURNAL")]
       public string OidJournal { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID_CNY")]
       public int IdCNY { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("SY_CNY")]
       public string Sycny { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("EXCHG_RATE_RCV")]
       public decimal EXCHGRateRCV { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("EXCHG_RATE_RTN")]
       public decimal EXCHGRateRTN { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("EXCHG_FEE")]
       public decimal Exchgfee { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AMT_SALE")]
       public decimal AMTSale { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AMT_RCV")]
       public decimal Amtrcv { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AMT_RTN")]
       public decimal Amtrtn { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TY_TND")]
       public string Tytnd { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FL_MAIN_TND")]
       public int Flmaintnd { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LOCAL_AMT_RND")]
       public decimal LocalAMTRND { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DE_TND")]
       public string Detnd { get; set; }


       #endregion Public Properties
   }
}
