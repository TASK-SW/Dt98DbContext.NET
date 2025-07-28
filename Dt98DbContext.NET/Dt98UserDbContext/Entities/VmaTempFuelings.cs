using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class VmaTempFuelings
    {
        #region Public Constructors

        public VmaTempFuelings()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime FuelingTime { get; set; }
        public int ProductId { get; set; }
        public int FuelPointId { get; set; }
        public int NozzleId { get; set; }
        public int ProcessingState { get; set; }
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }
        public string TankConfig { get; set; }

        #endregion Public Properties
    }
}