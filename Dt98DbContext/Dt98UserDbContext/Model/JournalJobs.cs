using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("JOURNALJOBS")]
   public class JournalJobs
   {
      #region Public Constructors

       public JournalJobs()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID_JOURNAL")]
       public string OidJournal { get; set; }

       [Key, Column(Order = 1)]
       //[Column("ProviderId")]
       public int ProviderId { get; set; }

       [Key, Column(Order = 2)]
       //[Column("JobId")]
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
