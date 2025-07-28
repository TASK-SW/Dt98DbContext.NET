using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class Schedule
    {
        #region Public Constructors

        public Schedule()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }
        public int Mode { get; set; }
        public int Interval { get; set; }
        public int DayOffSet { get; set; }
        public int TimeOffSet { get; set; }
        public DateTime LastDate { get; set; }
        public DateTime NextDate { get; set; }
        public string FileName { get; set; }
        public string Command { get; set; }
        public int ComSvr { get; set; }

        #endregion Public Properties
    }
}