//==================================================================================================
//  FILE        :   VMA_TankContents.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("VMA_TankContents")]
   public class VMATankContents
   {
      #region Public Constructors

       public VMATankContents()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("TankId")]
       public int TankId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ProductId")]
       public int ProductId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ProcessingTime")]
       public DateTime ProcessingTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VMASeqNumber")]
       public int VMASeqNumber { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VMAType")]
       public int VMAType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VMATypeSeqNumber")]
       public int VMATypeSeqNumber { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OrderNumber")]
       public int OrderNumber { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TankContentsType")]
       public int TankContentsType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TankContents")]
       public decimal TankContents { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ProductLevel")]
       public decimal ProductLevel { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("WaterLevel")]
       public decimal WaterLevel { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("WaterVolume")]
       public decimal WaterVolume { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Temperature")]
       public decimal Temperature { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Density")]
       public decimal Density { get; set; }


       #endregion Public Properties
   }
}
