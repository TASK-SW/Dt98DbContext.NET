//==================================================================================================
//  FILE        :   VMA_History.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("VMA_History")]
   public class VMA_History
   {
      #region Public Constructors

       public VMA_History()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("ProductId")]
       public int ProductId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FuelPointId")]
       public int FuelPointId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("NozzleId")]
       public int NozzleId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TankId")]
       public int TankId { get; set; }

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

       [System.ComponentModel.DataAnnotations.Schema.Column("Status")]
       public int Status { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PlannedTime")]
       public DateTime PlannedTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("UnitPrice")]
       public decimal UnitPrice { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("NewUnitPrice")]
       public decimal NewUnitPrice { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Volume")]
       public decimal Volume { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Amount")]
       public decimal Amount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ResultCode")]
       public int ResultCode { get; set; }


       #endregion Public Properties
   }
}
