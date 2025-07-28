using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class CardTrxCount001
    {
        #region Public Constructors

        public CardTrxCount001()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Pan { get; set; }
        public int Count { get; set; }
        public DateTime EditDate { get; set; }

        #endregion Public Properties
    }
}