//==================================================================================================
//  FILE        :   DEV_SETTING.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("DEV_SETTING")]
   public class DevSetting
   {
      #region Public Constructors

       public DevSetting()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("ID_DEV_CFG")]
       public string IdDevCFG { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VAL_DEV_SET")]
       public string ValDevSet { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TYP_DEV_SET")]
       public int TypDevSet { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID_DEV_SET")]
       public string IdDevSet { get; set; }


       #endregion Public Properties
   }
}
