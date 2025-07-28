namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class persFuelIngPoints
    {
        public persFuelIngPoints()
        {
        }

        public string Oid { get; set; }
        public string OidFuelSale { get; set; }
        public int ControlState { get; set; }
        public int LastError { get; set; }
        public int ErrorCount { get; set; }
        public int CurrentNozzle { get; set; }
        public int LtNummeRateUr { get; set; }
        public int LtVolume { get; set; }
        public int LtAmount { get; set; }
        public int LtNozzle { get; set; }
        public int PsState { get; set; }
        public int PsError { get; set; }
        public int PsCountEr1 { get; set; }
        public int PsCountEr2 { get; set; }
        public int PsCountEr3 { get; set; }
        public int PsCountEr4 { get; set; }
        public int PsNummeRateUr { get; set; }
    }
}