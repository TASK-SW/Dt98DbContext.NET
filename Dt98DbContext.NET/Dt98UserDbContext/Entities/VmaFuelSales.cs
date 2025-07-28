using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class VmaFuelSales
    {
        #region Public Constructors

        public VmaFuelSales()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime AuthorizationTime { get; set; }
        public DateTime FuelStartTime { get; set; }
        public DateTime FuelEndTime { get; set; }
        public string TerminalId { get; set; }
        public string PaymentType { get; set; }
        public int ProductId { get; set; }
        public int FuelPointId { get; set; }
        public int NozzleId { get; set; }
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }
        public decimal UnitPrice { get; set; }
        public int HostDeliveryState { get; set; }

        #endregion Public Properties
    }
}