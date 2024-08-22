//==================================================================================================
//  FILE        :   JOURNALJOBS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("JOURNALJOBS")]
   public class JournalJobs
   {
      #region Public Constructors

       public JournalJobs()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_JOURNAL")]
       public string OidJournal { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ProviderId")]
       public int ProviderId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("JobId")]
       public int JobId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LastUpdate")]
       public DateTime LastUpdate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ResultCode")]
       public int ResultCode { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("JobStatus")]
       public int JobStatus { get; set; }


       #endregion Public Properties
   }
}
