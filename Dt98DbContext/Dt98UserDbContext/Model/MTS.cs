//==================================================================================================
//  FILE        :   MTS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("MTS")]
   public class Mts
   {
      #region Public Constructors

       public Mts()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ProductSign")]
       public string ProductSign { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ProductCode")]
       public int ProductCode { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("NewPrice")]
       public decimal NewPrice { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OldPrice")]
       public decimal OldPrice { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ServiceMode")]
       public int ServiceMode { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DateTime")]
       public DateTime DateTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OrderNumber")]
       public int OrderNumber { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }


       #endregion Public Properties
   }
}
