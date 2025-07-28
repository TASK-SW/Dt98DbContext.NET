namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class DatacomOnlineCards
    {
        public DatacomOnlineCards()
        {
        }

        public int TrackNo { get; set; }
        public string CardId { get; set; }
        public int RecordState { get; set; }
        public string ApplicationId { get; set; }
        public int OnlineCheckIndoor { get; set; }
        public int OnlineCheckOutdoor { get; set; }
        public decimal OnlinePresetOutdoor { get; set; }
        public decimal DownOptionLimitIndoor { get; set; }
        public decimal DownOptionLimitOutdoor { get; set; }
        public int DownOptionTransactionCount { get; set; }
        public int DownOptionCheckBlacklist { get; set; }
        public decimal OnlineFloorLimit { get; set; }
        public int AuthorizationHost1Id { get; set; }
        public int AuthorizationHost2Id { get; set; }
        public int TdFileOnlineInformation { get; set; }
        public string OnlineSiteId { get; set; }
        public int OlisVersion { get; set; }
        public int SiteIdOlis1P { get; set; }
        public int CheckLuhn { get; set; }
        public int MinumumPanLength { get; set; }
        public int MaximumPanLength { get; set; }
        public int ExpirationDatePosition { get; set; }
        public int IssuerId { get; set; }
        public int SignatureAllowed { get; set; }
        public int BlacklistId { get; set; }
        public int DccQuery { get; set; }
    }
}