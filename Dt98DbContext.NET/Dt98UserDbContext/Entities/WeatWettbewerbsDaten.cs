using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class WeatWettbewerbsDaten
    {
        #region Public Constructors

        public WeatWettbewerbsDaten()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }
        public string OidWettBewerber { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime DateTime { get; set; }

        #endregion Public Properties
    }
}