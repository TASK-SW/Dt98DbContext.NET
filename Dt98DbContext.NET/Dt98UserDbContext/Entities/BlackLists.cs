using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class BlackLists
    {
        #region Public Constructors

        public BlackLists()
        { }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }

        public string OidType { get; set; }

        public int Id { get; set; }

        public string Version { get; set; }

        public int Validity { get; set; }

        public DateTime DownloadDate { get; set; }

        public string GenNo { get; set; }

        public string UpGenNo { get; set; }

        public DateTime GroupDownloadDate { get; set; }

        public int DataComId { get; set; }

        public int PanLength { get; set; }

        public int StripLength { get; set; }

        public int ExpirationDays { get; set; }

        #endregion Public Properties
    }
}