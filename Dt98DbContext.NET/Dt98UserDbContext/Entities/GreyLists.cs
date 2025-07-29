using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class GreyLists
    {
        #region Public Constructors

        public GreyLists()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }
        public string OidType { get; set; }
        public int Id { get; set; }
        public string GenNo { get; set; }
        public string UpGenNo { get; set; }
        public string Version { get; set; }
        public int? Validity { get; set; }
        public DateTime? DownloadDate { get; set; }

        #endregion Public Properties
    }
}