namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class CardDataCom
    {
        public CardDataCom()
        {
        }

        public string Oid { get; set; }
        public string DtCardTypeId { get; set; }
        public int DtRoundOpTotal { get; set; }
        public int DtRoundTrx { get; set; }
        public int DtXmitLimitOutdoor { get; set; }
        public int DtLimitOutdoor { get; set; }
        public int DtLimitTotal { get; set; }
        public int DtAcceptance { get; set; }
        public int DtXmitOnlineAuth { get; set; }
        public int DtOnlineAuth { get; set; }
        public int DtXmitPinAuth { get; set; }
        public int DtPinAuth { get; set; }
        public int PanStripBlackList { get; set; }
        public int PanStripTransAct { get; set; }
        public int TrxDelivMask { get; set; }
    }
}