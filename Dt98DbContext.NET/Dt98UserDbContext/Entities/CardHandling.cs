namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class CardHandling
    {
        public CardHandling()
        {
        }

        public string Oid { get; set; }
        public int ChkLuhn { get; set; }
        public int ChkDate { get; set; }
        public int PinCheckType { get; set; }
        public int PinScPos { get; set; }
        public int PinScVal { get; set; }
        public int LimitMin { get; set; }
        public int LimitFloor1 { get; set; }
        public int LimitFloor2 { get; set; }
        public int ProcessingType { get; set; }
        public int DefaultAmount { get; set; }
        public int LimitDateFrom { get; set; }
        public int LimitDateTo { get; set; }
        public int PinSkip { get; set; }
        public int LenVerifyNo { get; set; }
        public int ChkCardLen { get; set; }
        public int LimitTotalAmount { get; set; }
        public int LimitOutdoorAmount { get; set; }
        public int CountKeyCards { get; set; }
        public int KeyPos { get; set; }
        public int IssuerLen { get; set; }
        public int Mode { get; set; }
        public int TermCodeTabId { get; set; }
        public int ProdCodeTabId { get; set; }
        public int ReceiptCount { get; set; }
        public string OidKeyCardHandling { get; set; }
    }
}