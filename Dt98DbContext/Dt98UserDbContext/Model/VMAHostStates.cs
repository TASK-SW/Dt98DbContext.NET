//==================================================================================================
//  FILE        :   VMA_HostStates.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("VMA_HostStates")]
   public class VMAHostStates
   {
      #region Public Constructors

       public VMAHostStates()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("HostId")]
       public int HostId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("StateKey")]
       public string StateKey { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("StateValue")]
       public string StateValue { get; set; }


       #endregion Public Properties
   }
}
