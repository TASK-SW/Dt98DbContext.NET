using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class IssuerLists
    {
        #region Public Constructors

        public IssuerLists()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }
        public int DtVersion { get; set; }
        public DateTime DtLastUpdate { get; set; }

        #endregion Public Properties
    }
}