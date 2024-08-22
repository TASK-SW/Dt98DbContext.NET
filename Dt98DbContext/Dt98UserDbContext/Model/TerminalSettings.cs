//==================================================================================================
//  FILE        :   _sptTERMINALSETTINGS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptTERMINALSETTINGS")]
   public class TerminalSettings
   {
      #region Public Constructors

       public TerminalSettings()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_TERMINALCOMPONENT")]
       public string OidTerminalComponent { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
       public string Id { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VALUE")]
       public string Value { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TYPE")]
       public int Type { get; set; }


       #endregion Public Properties
   }
}
