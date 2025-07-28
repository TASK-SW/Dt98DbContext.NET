using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class VmaRecords
    {
        #region Public Constructors

        public VmaRecords()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public int ProductId { get; set; }
        public int FuelpointId { get; set; }
        public int NozzleId { get; set; }
        public DateTime TsBegin { get; set; }
        public DateTime Tsend { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public decimal Volume { get; set; }
        public decimal Amount { get; set; }
        public int HostDeliveryState { get; set; }
        public int OrderNumber { get; set; }
        public DateTime TsPlanned { get; set; }

        #endregion Public Properties
    }
}