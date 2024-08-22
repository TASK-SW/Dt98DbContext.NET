//==================================================================================================
//  FILE        :   VMA_FuelSales.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("VMA_FuelSales")]
   public class VMAFuelSales
   {
      #region Public Constructors

       public VMAFuelSales()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("EntryTime")]
       public DateTime EntryTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AuthorizationTime")]
       public DateTime AuthorizationTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FuelStartTime")]
       public DateTime FuelStartTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FuelEndTime")]
       public DateTime FuelEndTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TerminalId")]
       public string TerminalId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PaymentType")]
       public string PaymentType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ProductId")]
       public int ProductId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FuelPointId")]
       public int FuelPointId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("NozzleId")]
       public int NozzleId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Amount")]
       public decimal Amount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Volume")]
       public decimal Volume { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("UnitPrice")]
       public decimal UnitPrice { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }


       #endregion Public Properties
   }
}
