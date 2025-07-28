using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class CardDlyTotals
    {
        #region Public Constructors

        public CardDlyTotals()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }
        public string OidType { get; set; }
        public int Id { get; set; }
        public DateTime ResetDate { get; set; }

        #endregion Public Properties
    }
}