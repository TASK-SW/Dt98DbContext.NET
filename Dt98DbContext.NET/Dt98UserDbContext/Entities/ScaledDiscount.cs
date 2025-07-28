namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class ScaledDiscount
    {
        public ScaledDiscount()
        {
        }

        public int ItemId { get; set; }
        public decimal Threshold { get; set; }
        public int Type { get; set; }
        public decimal Amount { get; set; }
    }
}