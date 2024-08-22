//==================================================================================================
//  FILE        :   _sptPRODUCTCODEMAPS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     19.07.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptPRODUCTCODEMAPS")]
   public class sptProductCodeMaps
   {
      #region Public Constructors

       public sptProductCodeMaps()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Key]
       [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
       public int Id { get; set; }

       [System.ComponentModel.DataAnnotations.Key]
       [System.ComponentModel.DataAnnotations.Schema.Column("INTCODE")]
       public int INTCode { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("EXTCODE")]
       public int EXTCode { get; set; }


       #endregion Public Properties
   }
}
