using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(OidJournal), nameof(ProviderId), nameof(JobId))]
   [Table("JOURNALJOBS")]
   public class JournalJobs
   {
      #region Public Constructors

       public JournalJobs()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID_JOURNAL")]
       public string OidJournal { get; set; }

       [Column("ProviderId")]
       public int ProviderId { get; set; }

       [Column("JobId")]
       public int JobId { get; set; }

       [Column("LastUpdate")]
       public DateTime LastUpdate { get; set; }

       [Column("ResultCode")]
       public int ResultCode { get; set; }

       [Column("JobStatus")]
       public int JobStatus { get; set; }


       #endregion Public Properties
   }
}
