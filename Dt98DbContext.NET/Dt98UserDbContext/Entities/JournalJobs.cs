using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class JournalJobs
    {
        #region Public Constructors

        public JournalJobs()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string OidJournal { get; set; }
        public int ProviderId { get; set; }
        public int JobId { get; set; }
        public DateTime LastUpdate { get; set; }
        public int ResultCode { get; set; }
        public int JobStatus { get; set; }

        #endregion Public Properties
    }
}