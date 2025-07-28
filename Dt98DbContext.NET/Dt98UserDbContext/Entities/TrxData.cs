using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class TrxData
    {
        #region Public Constructors

        public TrxData()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string OidTrx { get; set; }
        public int Generation { get; set; }
        public int DtSequence { get; set; }
        public decimal DtTotalAmount { get; set; }
        public DateTime DtDate { get; set; }
        public string DtJourHead { get; set; }
        public string DtTransAct { get; set; }

        #endregion Public Properties
    }
}