//==================================================================================================
//  FILE        :   REDLIST046.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("REDLIST046")]
   public class RedList_046
   {
      #region Public Constructors

       public RedList_046()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("PAN")]
       public string PAN { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("COUNT")]
       public int Count { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("EDITDATE")]
       public DateTime EditDate { get; set; }


       #endregion Public Properties
   }
}
