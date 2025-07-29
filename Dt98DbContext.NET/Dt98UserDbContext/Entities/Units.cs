namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class Units
    {
        public Units()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortCut { get; set; }
        public int? Decimals { get; set; }
    }
}