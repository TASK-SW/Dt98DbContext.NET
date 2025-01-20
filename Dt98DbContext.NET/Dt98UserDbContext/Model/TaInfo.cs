using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("TA_INFO")]
   public class TaInfo
   {
      #region Public Constructors

       public TaInfo()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public int Oid { get; set; }

       [Column("APP_ID")]
       public string AppId { get; set; }

       [Column("REC_ID")]
       public string RecId { get; set; }

       [Column("DT_TIMESTAMP")]
       public DateTime DtTimeStamp { get; set; }

       [Column("FILENAME")]
       public string FileName { get; set; }

       [Column("STATUS")]
       public int Status { get; set; }

       [Column("CONTENT")]
       public string Content { get; set; }


       #endregion Public Properties
   }
}
