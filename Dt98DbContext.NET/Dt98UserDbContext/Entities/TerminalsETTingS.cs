namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class TerminalSettings
    {
        public TerminalSettings()
        {
        }

        public string Oid { get; set; }
        public string OidTerminalComponent { get; set; }
        public string Id { get; set; }
        public string Value { get; set; }
        public int? Type { get; set; }
    }
}