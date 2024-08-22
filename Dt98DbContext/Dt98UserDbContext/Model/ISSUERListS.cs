//==================================================================================================
//  FILE        :   ISSUERLISTS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("ISSUERLISTS")]
   public class ISSUERListS
   {
      #region Public Constructors

       public ISSUERListS()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_VERSION")]
       public int DTVersion { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_LASTUPDATE")]
       public DateTime DTLastUpdate { get; set; }


       #endregion Public Properties
   }
}
