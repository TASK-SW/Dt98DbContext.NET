namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class OpTotalData
    {
        public OpTotalData()
        {
        }

        public int Oid { get; set; }
        public string OidHost { get; set; }
        public int Generation { get; set; }
        public int DtType { get; set; }
        public string DtTransactionId { get; set; }
        public string DtProductId { get; set; }
        public decimal DtAmount { get; set; }
        public decimal DtQuantity { get; set; }
        public string UnitCode { get; set; }
        public int DtCount { get; set; }
    }
}