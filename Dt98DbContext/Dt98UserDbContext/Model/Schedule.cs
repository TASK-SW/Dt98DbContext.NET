//==================================================================================================
//  FILE        :   SCHEDULE.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("SCHEDULE")]
   public class Schedule
   {
      #region Public Constructors

       public Schedule()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("MODE")]
       public int Mode { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("INTERVAL")]
       public int Interval { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DAYOFFSET")]
       public int DayOffSet { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TIMEOFFSET")]
       public int TimeOffSet { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LASTDATE")]
       public DateTime LastDate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("NEXTDATE")]
       public DateTime NextDate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FILENAME")]
       public string FileName { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("COMMAND")]
       public string Command { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("COMSVR")]
       public int ComSVR { get; set; }


       #endregion Public Properties
   }
}
