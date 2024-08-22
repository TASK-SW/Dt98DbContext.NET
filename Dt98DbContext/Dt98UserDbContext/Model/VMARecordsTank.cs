//==================================================================================================
//  FILE        :   VMARECORDSTANK.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("VMARECORDSTANK")]
   public class VMARecordsTank
   {
      #region Public Constructors

       public VMARecordsTank()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("ProductId")]
       public int ProductId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FuelpointId")]
       public int FuelpointId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("NozzleId")]
       public int NozzleId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TSBegin")]
       public DateTime TSBegin { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TankId")]
       public int TankId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TankMeter")]
       public decimal TankMeter { get; set; }


       #endregion Public Properties
   }
}
