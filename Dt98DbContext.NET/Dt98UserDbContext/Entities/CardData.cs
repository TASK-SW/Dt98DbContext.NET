namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class CardData
    {
        public CardData()
        {
        }

        public string Pan { get; set; }
        public int? PinMode { get; set; }
        public int? Pin { get; set; }
        public int? MileageMode { get; set; }
        public int? Mileage { get; set; }
        public int? ServiceCode { get; set; }
        public int? FuelLimit { get; set; }
        public int? PosDateElapse { get; set; }
        public int? ErrorCountMax { get; set; }
        public int? ErrorCountCur { get; set; }
        public int? RecordState { get; set; }
    }
}