using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(OidTrx), nameof(Generation), nameof(DtSequence))]
   [Table("TRXDATA")]
   public class TrxData
   {
      #region Public Constructors

       public TrxData()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OID_TRX")]
       public string OidTrx { get; set; }

        [Key]
        [Column("GENERATION")]
       public int Generation { get; set; }

        [Key]
        [Column("DT_SEQUENCE")]
       public int DtSequence { get; set; }

       [Column("DT_TOTALAMOUNT")]
       public decimal DtTotalAmount { get; set; }

       [Column("DT_DATE")]
       public DateTime DtDate { get; set; }

       [Column("DT_JOURHEAD")]
       public string DtJourHead { get; set; }

       [Column("DT_TRANSACT")]
       public string DtTransAct { get; set; }


       #endregion Public Properties
   }
}
