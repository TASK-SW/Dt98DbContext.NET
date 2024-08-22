//==================================================================================================
//  FILE        :   ScaledDiscount.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("ScaledDiscount")]
   public class ScaledDiscount
   {
      #region Public Constructors

       public ScaledDiscount()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("ItemId")]
       public int ItemId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Threshold")]
       public decimal Threshold { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Type")]
       public int Type { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Amount")]
       public decimal Amount { get; set; }


       #endregion Public Properties
   }
}
