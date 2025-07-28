using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class Mts
    {
        #region Public Constructors

        public Mts()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }
        public string ProductSign { get; set; }
        public int ProductCode { get; set; }
        public decimal NewPrice { get; set; }
        public decimal OldPrice { get; set; }
        public int ServiceMode { get; set; }
        public DateTime DateTime { get; set; }
        public int OrderNumber { get; set; }
        public int HostDeliveryState { get; set; }

        #endregion Public Properties
    }
}