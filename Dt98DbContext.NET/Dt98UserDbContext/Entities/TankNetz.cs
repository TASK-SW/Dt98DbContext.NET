using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class TankNetz
    {
        #region Public Constructors

        public TankNetz()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }
        public DateTime? DateTime { get; set; }
        public int? JournalId { get; set; }
        public int? StationId { get; set; }
        public int? TerminalId { get; set; }
        public string FirstCard { get; set; }
        public int? SecondCard { get; set; }
        public int? Mileage { get; set; }
        public int? AddInfo { get; set; }
        public int? ArticleId { get; set; }
        public int? FpId { get; set; }
        public int? ProductType { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Amount { get; set; }
        public int? Nummerator { get; set; }
        public int? Pin { get; set; }
        public string ArticleName { get; set; }
        public string TraceNo { get; set; }

        #endregion Public Properties
    }
}