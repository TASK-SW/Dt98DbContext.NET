using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class TankTransactions
    {
        #region Public Constructors

        public TankTransactions()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string PkId { get; set; }
        public DateTime TrxDate { get; set; }
        public int TrxType { get; set; }
        public int TankId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public string Info { get; set; }

        #endregion Public Properties
    }
}