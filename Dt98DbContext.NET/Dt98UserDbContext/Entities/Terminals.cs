namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class Terminals
    {
        public Terminals()
        {
        }

        public string Oid { get; set; }
        public string OidType { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int State { get; set; }
        public int TermLanguage { get; set; }
    }
}