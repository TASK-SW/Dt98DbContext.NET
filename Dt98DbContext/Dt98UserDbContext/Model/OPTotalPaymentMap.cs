//==================================================================================================
//  FILE        :   _sptOPTOTAL_PAYMENTMAP.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptOPTOTAL_PAYMENTMAP")]
   public class OPTotalPaymentMap
   {
      #region Public Constructors

       public OPTotalPaymentMap()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public int Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_PAYMENTTYPE")]
       public string OidPaymentType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_TERMINALTYPE")]
       public string OidTerminalType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TRANSACTION_ID")]
       public string TransactionId { get; set; }


       #endregion Public Properties
   }
}
