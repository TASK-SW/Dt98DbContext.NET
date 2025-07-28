using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class Vma_History
    {
        #region Public Constructors

        public Vma_History()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public int ProductId { get; set; }
        public int FuelPointId { get; set; }
        public int NozzleId { get; set; }
        public int TankId { get; set; }
        public DateTime ProcessingTime { get; set; }
        public int VmaSeqNumber { get; set; }
        public int VmaType { get; set; }
        public int VmaTypeSeqNumber { get; set; }
        public int OrderNumber { get; set; }
        public int Status { get; set; }
        public int HostDeliveryState { get; set; }
        public DateTime PlannedTime { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal NewUnitPrice { get; set; }
        public decimal Volume { get; set; }
        public decimal Amount { get; set; }
        public int ResultCode { get; set; }

        #endregion Public Properties
    }
}