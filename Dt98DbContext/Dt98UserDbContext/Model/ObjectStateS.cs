//==================================================================================================
//  FILE        :   OBJECTSTATES.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("OBJECTSTATES")]
   public class ObjectStateS
   {
      #region Public Constructors

       public ObjectStateS()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OBJTYPE")]
       public int Objtype { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OBJID")]
       public string ObjId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PARTYPE")]
       public int PArtype { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PARID")]
       public string PARId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("STATE")]
       public int State { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OBJSTATEIX")]
       public int ObjStateIX { get; set; }


       #endregion Public Properties
   }
}
