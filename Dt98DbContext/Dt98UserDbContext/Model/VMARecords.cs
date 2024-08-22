//==================================================================================================
//  FILE        :   VMARECORDS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("VMARECORDS")]
   public class VMARecords
   {
      #region Public Constructors

       public VMARecords()
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

       [System.ComponentModel.DataAnnotations.Schema.Column("TSEnd")]
       public DateTime TSEnd { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OldPrice")]
       public decimal OldPrice { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("NewPrice")]
       public decimal NewPrice { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Volume")]
       public decimal Volume { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Amount")]
       public decimal Amount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OrderNumber")]
       public int OrderNumber { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TSPlanned")]
       public DateTime TSPlanned { get; set; }


       #endregion Public Properties
   }
}
