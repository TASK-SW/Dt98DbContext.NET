//==================================================================================================
//  FILE        :   VMAHISTORY.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("VMAHISTORY")]
   public class VMAHistory
   {
      #region Public Constructors

       public VMAHistory()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("ProductId")]
       public int ProductId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VMAType")]
       public int VMAType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DateTime")]
       public DateTime DateTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OrderNumber")]
       public int OrderNumber { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("UnitPrice")]
       public decimal UnitPrice { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Volume")]
       public decimal Volume { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Amount")]
       public decimal Amount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VolumePeriod")]
       public decimal VolumePeriod { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AmountPeriod")]
       public decimal AmountPeriod { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("NewUnitPrice")]
       public decimal NewUnitPrice { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TSBegin")]
       public DateTime TSBegin { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TSPlanned")]
       public DateTime TSPlanned { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DeltaVolume")]
       public decimal DeltaVolume { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DeltaAmount")]
       public decimal DeltaAmount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LastDateTime")]
       public DateTime LastDateTime { get; set; }


       #endregion Public Properties
   }
}
