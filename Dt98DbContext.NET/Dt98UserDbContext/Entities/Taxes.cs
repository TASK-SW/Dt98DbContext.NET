namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class Taxes
    {
        public Taxes()
        {
        }

        public string Oid { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Tax { get; set; }
    }
}