//==================================================================================================
//  FILE        :   _sptTERMINALS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptTERMINALS")]
   public class TerminalS
   {
      #region Public Constructors

       public TerminalS()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_TYPE")]
       public string OidType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
       public int Id { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("NAME")]
       public string Name { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("STATE")]
       public int State { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TERMLANGUAGE")]
       public int TermLanguage { get; set; }


       #endregion Public Properties
   }
}
