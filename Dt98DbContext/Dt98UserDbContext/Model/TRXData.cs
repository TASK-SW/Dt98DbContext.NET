using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("TRXDATA")]
   public class TrxData
   {
      #region Public Constructors

       public TrxData()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID_TRX")]
       public string OidTrx { get; set; }

       [Key, Column(Order = 1)]
       //[Column("GENERATION")]
       public int Generation { get; set; }

       [Key, Column(Order = 2)]
       //[Column("DT_SEQUENCE")]
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
