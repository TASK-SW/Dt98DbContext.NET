//==================================================================================================
//  FILE        :   _sctUNITS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     19.07.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sctUNITS")]
   public class sctUnitS
   {
      #region Public Constructors

       public sctUnitS()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Key]
       [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
       public int Id { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("NAME")]
       public string Name { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("SHORTCUT")]
       public string ShortCut { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DECIMALS")]
       public int Decimals { get; set; }


       #endregion Public Properties
   }
}
