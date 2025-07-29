using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class OpTotalFiles
    {
        #region Public Constructors

        public OpTotalFiles()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }
        public DateTime? StartDate { get; set; }
        public int ActualGen { get; set; }
        public int DelivGen { get; set; }
        public int? DtVersion { get; set; }

        #endregion Public Properties
    }
}