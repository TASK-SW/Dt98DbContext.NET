namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class Hosts
    {
        public Hosts()
        {
        }

        public string Oid { get; set; }
        public string OidType { get; set; }
        public string DtName { get; set; }
        public string DtStationId { get; set; }
        public string DtIssuerListOid { get; set; }
        public string DtFileIdMsd { get; set; }
        public string DtShortCut { get; set; }
        public string DtApplicationId { get; set; }
        public string DtInPath { get; set; }
        public string DtOutPath { get; set; }
        public string DtSlumPath { get; set; }
        public string DtCardHandlingOid { get; set; }
        public int DtCheckSystem { get; set; }
        public int DtCheckAcceptance { get; set; }
        public int DtDelivErOpTotal { get; set; }
        public string DtLoginName { get; set; }
        public string DtApplicationType { get; set; }
    }
}