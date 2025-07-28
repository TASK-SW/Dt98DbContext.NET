namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class VmaCurrent
    {
        public VmaCurrent()
        {
        }

        public int ProductId { get; set; }
        public int FuelPointId { get; set; }
        public int NozzleId { get; set; }
        public int TankId { get; set; }
        public decimal Volume { get; set; }
        public decimal Amount { get; set; }
    }
}