//==================================================================================================
//  FILE        :   VMA_TempFuelings.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("VMA_TempFuelings")]
   public class VMATempFuelings
   {
      #region Public Constructors

       public VMATempFuelings()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("EntryTime")]
       public DateTime EntryTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FuelingTime")]
       public DateTime FuelingTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ProductId")]
       public int ProductId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FuelPointId")]
       public int FuelPointId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("NozzleId")]
       public int NozzleId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ProcessingState")]
       public int ProcessingState { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Amount")]
       public decimal Amount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Volume")]
       public decimal Volume { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TankConfig")]
       public string TankConfig { get; set; }


       #endregion Public Properties
   }
}
