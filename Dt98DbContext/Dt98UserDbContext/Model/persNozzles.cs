//==================================================================================================
//  FILE        :   _persNOZZLES.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_persNOZZLES")]
   public class persNozzles
   {
      #region Public Constructors

       public persNozzles()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VOLUME")]
       public decimal Volume { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AMOUNT")]
       public decimal Amount { get; set; }


       #endregion Public Properties
   }
}
