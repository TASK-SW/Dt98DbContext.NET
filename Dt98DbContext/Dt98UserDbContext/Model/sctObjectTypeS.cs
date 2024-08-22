//==================================================================================================
//  FILE        :   _sctOBJECTTYPES.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     19.07.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sctOBJECTTYPES")]
   public class sctObjectTypeS
   {
      #region Public Constructors

       public sctObjectTypeS()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Key]
       [System.ComponentModel.DataAnnotations.Schema.Column("OBJTYPE")]
       public int Objtype { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OBJTYPENAME")]
       public string ObjtypeName { get; set; }


       #endregion Public Properties
   }
}
