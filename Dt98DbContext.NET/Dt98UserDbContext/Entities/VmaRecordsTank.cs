using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class VmaRecordsTank
    {
        #region Public Constructors

        public VmaRecordsTank()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public int ProductId { get; set; }
        public int FuelpointId { get; set; }
        public int NozzleId { get; set; }
        public DateTime TsBegin { get; set; }
        public int TankId { get; set; }
        public decimal TankMeter { get; set; }

        #endregion Public Properties
    }
}