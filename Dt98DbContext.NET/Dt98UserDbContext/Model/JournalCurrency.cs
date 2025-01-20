using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(OidJournal), nameof(IdCny))]
   [Table("JOURNALCURRENCY")]
   public class JournalCurrency
   {
      #region Public Constructors

       public JournalCurrency()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID_JOURNAL")]
       public string OidJournal { get; set; }

       [Column("ID_CNY")]
       public int IdCny { get; set; }

       [Column("SY_CNY")]
       public string SyCny { get; set; }

       [Column("EXCHG_RATE_RCV")]
       public decimal ExchgRateRcv { get; set; }

       [Column("EXCHG_RATE_RTN")]
       public decimal ExchgRateRtn { get; set; }

       [Column("EXCHG_FEE")]
       public decimal ExchgFee { get; set; }

       [Column("AMT_SALE")]
       public decimal AmtSale { get; set; }

       [Column("AMT_RCV")]
       public decimal AmtRcv { get; set; }

       [Column("AMT_RTN")]
       public decimal AmtRtn { get; set; }

       [Column("TY_TND")]
       public string TyTnd { get; set; }

       [Column("FL_MAIN_TND")]
       public int FlmAIntNd { get; set; }

       [Column("LOCAL_AMT_RND")]
       public decimal LocalAmtRnd { get; set; }

       [Column("DE_TND")]
       public string DeTnd { get; set; }


       #endregion Public Properties
   }
}
