namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class Tanks
    {
        public Tanks()
        {
        }

        public string Oid { get; set; }
        public string OidType { get; set; }
        public string OidArticle { get; set; }
        public string OidTankLevelTab { get; set; }
        public int Id { get; set; }
        public decimal Volume { get; set; }
        public decimal Length { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
    }
}