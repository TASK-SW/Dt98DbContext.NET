namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class CardTracks
    {
        public CardTracks()
        {
        }

        public string Oid { get; set; }
        public string OidCardProfile { get; set; }
        public int TrackPos { get; set; }
        public int LowVal { get; set; }
        public int UpVal { get; set; }
        public int Condition { get; set; }
    }
}