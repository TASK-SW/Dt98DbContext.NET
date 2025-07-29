using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class OpTotalGenerations
    {
        #region Public Constructors

        public OpTotalGenerations()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string OidHost { get; set; }
        public int Generation { get; set; }
        public DateTime CycleStart { get; set; }
        public DateTime CycleEnd { get; set; }
        public DateTime? CreationStart { get; set; }
        public DateTime? CreationEnd { get; set; }
        public DateTime? DeliveryDate { get; set; }

        #endregion Public Properties
    }
}