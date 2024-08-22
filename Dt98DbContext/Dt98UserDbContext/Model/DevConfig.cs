//==================================================================================================
//  FILE        :   DEV_CONFIG.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("DEV_CONFIG")]
   public class DevConfig
   {
      #region Public Constructors

       public DevConfig()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("ID_DEV_CFG")]
       public string IdDevCFG { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID_DEV_TYP")]
       public string IdDevTyp { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID_DEV_CLS")]
       public string IdDevCLS { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID_DEV_PAR")]
       public string IdDevPAR { get; set; }


       #endregion Public Properties
   }
}
