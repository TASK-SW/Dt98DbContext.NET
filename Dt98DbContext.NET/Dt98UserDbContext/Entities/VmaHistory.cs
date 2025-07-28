using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class VmaHistory
    {
        #region Public Constructors

        public VmaHistory()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public int ProductId { get; set; }
        public int VmaType { get; set; }
        public DateTime DateTime { get; set; }
        public int OrderNumber { get; set; }
        public decimal UnitPrice { get; set; }
        public int HostDeliveryState { get; set; }
        public decimal Volume { get; set; }
        public decimal Amount { get; set; }
        public decimal VolumePeriod { get; set; }
        public decimal AmountPeriod { get; set; }
        public decimal NewUnitPrice { get; set; }
        public DateTime TsBegin { get; set; }
        public DateTime TsPlanned { get; set; }
        public decimal DeltaVolume { get; set; }
        public decimal DeltaAmount { get; set; }
        public DateTime LastDateTime { get; set; }

        #endregion Public Properties
    }
}