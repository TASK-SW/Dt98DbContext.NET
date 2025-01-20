using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("SCHEDULE")]
   public class Schedule
   {
      #region Public Constructors

       public Schedule()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("MODE")]
       public int Mode { get; set; }

       [Column("INTERVAL")]
       public int Interval { get; set; }

       [Column("DAYOFFSET")]
       public int DayOffSet { get; set; }

       [Column("TIMEOFFSET")]
       public int TimeOffSet { get; set; }

       [Column("LASTDATE")]
       public DateTime LastDate { get; set; }

       [Column("NEXTDATE")]
       public DateTime NextDate { get; set; }

       [Column("FILENAME")]
       public string FileName { get; set; }

       [Column("COMMAND")]
       public string Command { get; set; }

       [Column("COMSVR")]
       public int ComSvr { get; set; }


       #endregion Public Properties
   }
}
