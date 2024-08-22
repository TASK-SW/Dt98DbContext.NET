//==================================================================================================
//  FILE        :   DEV_VALTYPE.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("DEV_VALTYPE")]
   public class DevValType
   {
      #region Public Constructors

       public DevValType()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("ID_VAL_TYPE")]
       public int IdValType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("NM_VAL_TYPE")]
       public string NMValType { get; set; }


       #endregion Public Properties
   }
}
