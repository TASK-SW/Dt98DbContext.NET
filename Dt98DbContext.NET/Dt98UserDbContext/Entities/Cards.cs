namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class Cards
    {
        public Cards()
        {
        }

        public string Oid { get; set; }
        public string OidType { get; set; }
        public string OidTerminal { get; set; }
        public int Id { get; set; }
        public int? State { get; set; }
        public int? RecState { get; set; }
        public string OidCardHandling { get; set; }
        public string OidPaymentType { get; set; }
    }
}