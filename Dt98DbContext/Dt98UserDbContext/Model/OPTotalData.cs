//==================================================================================================
//  FILE        :   OPTOTALDATA.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("OPTOTALDATA")]
   public class OPTotalData
   {
      #region Public Constructors

       public OPTotalData()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public int Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_HOST")]
       public string OidHost { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("GENERATION")]
       public int Generation { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_TYPE")]
       public int DTType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_TRANSACTION_ID")]
       public string DTTransactionId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_PRODUCT_ID")]
       public string DTProductId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_AMOUNT")]
       public decimal DTAmount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_QUANTITY")]
       public decimal DTQuantity { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("UNITCODE")]
       public string UnitCode { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_COUNT")]
       public int DTCount { get; set; }


       #endregion Public Properties
   }
}
