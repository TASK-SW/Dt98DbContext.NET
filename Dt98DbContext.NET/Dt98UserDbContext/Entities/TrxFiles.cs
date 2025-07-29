using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class TrxFiles
    {
        #region Public Constructors

        public TrxFiles()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string OidTrxFiles { get; set; }
        public int DtSequence { get; set; }
        public DateTime? DtResetDate { get; set; }
        public int? DtActNum { get; set; }
        public int? DtPASNum { get; set; }
        public int? DtVersion { get; set; }
        public DateTime? DtLastTrxDate { get; set; }

        #endregion Public Properties
    }
}