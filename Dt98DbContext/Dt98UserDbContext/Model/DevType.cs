//==================================================================================================
//  FILE        :   DEV_TYPE.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("DEV_TYPE")]
   public class DevType
   {
      #region Public Constructors

       public DevType()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("ID_DEV_TYP")]
       public string IdDevTyp { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID_DEV_CLS")]
       public string IdDevCLS { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("NM_DEV_TYP")]
       public string NMDevTyp { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CLSID_DEV_TYP")]
       public string CLSIdDevTyp { get; set; }


       #endregion Public Properties
   }
}
