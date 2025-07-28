using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class VmaHistoryTank
    {
        #region Public Constructors

        public VmaHistoryTank()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public int ProductId { get; set; }
        public int TankId { get; set; }
        public int VmaType { get; set; }
        public DateTime DateTime { get; set; }
        public int OrderNumber { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPriceNew { get; set; }
        public decimal TankContent { get; set; }
        public decimal TankMeter { get; set; }
        public int HostDeliveryState { get; set; }

        #endregion Public Properties
    }
}