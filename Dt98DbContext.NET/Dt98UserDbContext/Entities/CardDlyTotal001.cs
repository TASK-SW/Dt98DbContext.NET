using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class CardDlyTotal001
    {
        #region Public Constructors

        public CardDlyTotal001()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Pan { get; set; }
        public decimal Amount { get; set; }
        public decimal OutdoorAmount { get; set; }
        public DateTime EditDate { get; set; }
        public decimal DopIndoorAmt { get; set; }
        public int DopIndoorCnt { get; set; }
        public decimal DopOutdoorAmt { get; set; }
        public int DopOutdoorCnt { get; set; }

        #endregion Public Properties
    }
}