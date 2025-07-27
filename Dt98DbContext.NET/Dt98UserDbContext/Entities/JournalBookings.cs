namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class JournalBookings
    {
        #region Public Constructors

        public JournalBookings()
        { }

        #endregion Public Constructors

        #region Public Properties

        public string OidBooking { get; set; }
        public string OidJournal { get; set; }
        public JournalHeader Header { get; set; }

        public int BookingId { get; set; }
        public string ArticleId { get; set; }
        public string Article { get; set; }
        public string ShortName { get; set; }
        public string ReceiptText { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Tax { get; set; }
        public int FpId { get; set; }
        public int NozzleId { get; set; }
        public decimal FpAmount { get; set; }
        public string ArtSubGrp { get; set; }
        public string ArtGrp { get; set; }
        public int Unit { get; set; }
        public string OidStornoOrigin { get; set; }
        public int DscType { get; set; }
        public decimal DscRate { get; set; }
        public decimal DscAmt { get; set; }
        public string EanCode { get; set; }
        public int VideosEqNo { get; set; }
        public int FpCrc { get; set; }
        public int FrgnIdCny { get; set; }
        public decimal FrgnUnitPrc { get; set; }

        #endregion Public Properties
    }
}