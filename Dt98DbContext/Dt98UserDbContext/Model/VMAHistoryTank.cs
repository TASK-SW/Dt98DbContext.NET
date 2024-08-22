//==================================================================================================
//  FILE        :   VMAHISTORYTANK.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("VMAHISTORYTANK")]
   public class VMAHistoryTank
   {
      #region Public Constructors

       public VMAHistoryTank()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("ProductId")]
       public int ProductId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TankId")]
       public int TankId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VMAType")]
       public int VMAType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DateTime")]
       public DateTime DateTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OrderNumber")]
       public int OrderNumber { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("UnitPrice")]
       public decimal UnitPrice { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("UnitPriceNew")]
       public decimal UnitPriceNew { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TankContent")]
       public decimal TankContent { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TankMeter")]
       public decimal TankMeter { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }


       #endregion Public Properties
   }
}
