//==================================================================================================
//  FILE        :   SAMMELRECORDS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("SAMMELRECORDS")]
   public class SammelRecords
   {
      #region Public Constructors

       public SammelRecords()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("DateTime")]
       public DateTime DateTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Data")]
       public string Data { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }


       #endregion Public Properties
   }
}
