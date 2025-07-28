namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class CardProducts
    {
        public CardProducts()
        {
        }

        public string Oid { get; set; }
        public string OidCardType { get; set; }
        public int ServiceCode { get; set; }
        public int ServiceValue { get; set; }
        public string Products { get; set; }
    }
}