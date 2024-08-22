//==================================================================================================
//  FILE        :   TankTransactions.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("TankTransactions")]
   public class TankTransactions
   {
      #region Public Constructors

       public TankTransactions()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("PkId")]
       public string PkId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TrxDate")]
       public DateTime TrxDate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TrxType")]
       public int TrxType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TankId")]
       public int TankId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ProductId")]
       public int ProductId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Quantity")]
       public decimal Quantity { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Info")]
       public string Info { get; set; }


       #endregion Public Properties
   }
}
