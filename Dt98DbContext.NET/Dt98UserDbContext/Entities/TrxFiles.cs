using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Oid))]
   [Table("TRXFILES")]
   public class TrxFiles
   {
      #region Public Constructors

       public TrxFiles()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        //FK : sptTrxFiles.Oid
        [Key()]
       [Column("OID")]
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
