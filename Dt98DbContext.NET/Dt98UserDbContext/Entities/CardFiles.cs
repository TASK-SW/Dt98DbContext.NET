namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class CardFiles
    {
        public CardFiles()
        {
        }

        public string Oid { get; set; }
        public string OidBlackList { get; set; }
        public string OidGreyList { get; set; }
        public string OidRedList { get; set; }
        public string OidCardDlyTotal { get; set; }
        public string OidCardTrxCount { get; set; }
        public string OidTrxFile { get; set; }
        public string OidHost { get; set; }
        public string OidCardDataCom { get; set; }
        public string OidForeignTrx { get; set; }
    }
}