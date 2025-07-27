namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class JournalCurrency
    {
        //public JournalCurrency() { }

        #region Public Properties

        public string OidJournal { get; set; }
        public int IdCny { get; set; }
        public JournalHeader Header { get; set; }

        public string SyCny { get; set; }
        public decimal ExchgRateRcv { get; set; }
        public decimal ExchgRateRtn { get; set; }
        public decimal ExchgFee { get; set; }
        public decimal AmtSale { get; set; }
        public decimal AmtRcv { get; set; }
        public decimal AmtRtn { get; set; }
        public string TyTnd { get; set; }
        public int FlmAIntNd { get; set; }
        public decimal LocalAmtRnd { get; set; }
        public string DeTnd { get; set; }

        #endregion Public Properties
    }
}