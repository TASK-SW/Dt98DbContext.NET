using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("TRXFILES")]
   public class TrxFiles
   {
      #region Public Constructors

       public TrxFiles()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("DT_SEQUENCE")]
       public int DtSequence { get; set; }

       [Column("DT_RESETDATE")]
       public DateTime DtResetDate { get; set; }

       [Column("DT_ACTNUM")]
       public int DtActNum { get; set; }

       [Column("DT_PASNUM")]
       public int DtPASNum { get; set; }

       [Column("DT_VERSION")]
       public int DtVersion { get; set; }

       [Column("DT_LASTTRXDATE")]
       public DateTime DtLastTrxDate { get; set; }


       #endregion Public Properties
   }
}
