//==================================================================================================
//  FILE        :   OPTOTALFILES.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("OPTOTALFILES")]
   public class OPTotalFiles
   {
      #region Public Constructors

       public OPTotalFiles()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("STARTDATE")]
       public DateTime StartDate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ACTUALGEN")]
       public int ActualGen { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DELIVGEN")]
       public int DelivGen { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_VERSION")]
       public int DTVersion { get; set; }


       #endregion Public Properties
   }
}
