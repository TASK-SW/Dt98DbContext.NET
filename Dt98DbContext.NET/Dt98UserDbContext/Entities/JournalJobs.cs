using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(OidJournal), nameof(ProviderId), nameof(JobId))]
   [Table("JOURNALJOBS")]
   public class JournalJobs
   {
      #region Public Constructors

       public JournalJobs()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        //FK : JournalHeader.Oid
        [Key]
        [Column("OID_JOURNAL")]
       public string OidJournal { get; set; }

        [Key]
        [Column("ProviderId")]
       public int ProviderId { get; set; }

        [Key]
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
