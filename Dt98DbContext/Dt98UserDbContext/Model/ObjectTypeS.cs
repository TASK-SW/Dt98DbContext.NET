//==================================================================================================
//  FILE        :   _sctOBJECTTYPES.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sctOBJECTTYPES")]
   public class ObjectTypeS
   {
      #region Public Constructors

       public ObjectTypeS()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OBJTYPE")]
       public int Objtype { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OBJTYPENAME")]
       public string ObjtypeName { get; set; }


       #endregion Public Properties
   }
}
