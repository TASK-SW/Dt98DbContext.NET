using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class TaInfo
    {
        #region Public Constructors

        public TaInfo()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public int Oid { get; set; }
        public string AppId { get; set; }
        public string RecId { get; set; }
        public DateTime DtTimeStamp { get; set; }
        public string FileName { get; set; }
        public int Status { get; set; }
        public string Content { get; set; }

        #endregion Public Properties
    }
}