namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class OpTotalPaymentMap
    {
        public OpTotalPaymentMap()
        {
        }

        public int Oid { get; set; }
        public string OidPaymentType { get; set; }
        public string OidTerminalType { get; set; }
        public string TransactionId { get; set; }
    }
}