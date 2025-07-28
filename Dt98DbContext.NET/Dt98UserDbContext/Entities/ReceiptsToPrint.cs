namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class ReceiptsToPrint
    {
        public ReceiptsToPrint()
        {
        }

        public string OidJourHead { get; set; }
        public string TerminalId { get; set; }
        public string ReceiptMsg { get; set; }
        public int RetryPrintCount { get; set; }
    }
}