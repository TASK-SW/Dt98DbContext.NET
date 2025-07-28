using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class TrxGenerations
    {
        #region Public Constructors

        public TrxGenerations()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string OidTrx { get; set; }
        public int Generation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        #endregion Public Properties
    }
}