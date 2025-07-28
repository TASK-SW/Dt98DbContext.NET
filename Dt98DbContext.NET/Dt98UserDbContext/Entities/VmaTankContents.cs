using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class VmaTankContents
    {
        #region Public Constructors

        public VmaTankContents()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public int TankId { get; set; }
        public int ProductId { get; set; }
        public DateTime ProcessingTime { get; set; }
        public int VmaSeqNumber { get; set; }
        public int VmaType { get; set; }
        public int VmaTypeSeqNumber { get; set; }
        public int OrderNumber { get; set; }
        public int TankContentsType { get; set; }
        public int HostDeliveryState { get; set; }
        public decimal TankContents { get; set; }
        public decimal ProductLevel { get; set; }
        public decimal WaterLevel { get; set; }
        public decimal WaterVolume { get; set; }
        public decimal Temperature { get; set; }
        public decimal Density { get; set; }

        #endregion Public Properties
    }
}