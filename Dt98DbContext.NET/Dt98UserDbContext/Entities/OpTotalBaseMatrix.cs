namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class OpTotalBaseMatrix
    {
        public OpTotalBaseMatrix()
        {
        }

        public int Oid { get; set; }
        public string DtProductId { get; set; }
        public string DtTransactionId { get; set; }
        public int DtType { get; set; }
    }
}