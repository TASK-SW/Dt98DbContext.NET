//==================================================================================================
//  FILE        :   _sptCARDS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptCARDS")]
   public class CardS
   {
      #region Public Constructors

       public CardS()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_TYPE")]
       public string OidType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_TERMINAL")]
       public string OidTerminal { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
       public int Id { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("STATE")]
       public int State { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("RECSTATE")]
       public int RECState { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_CARDHANDLING")]
       public string OidCardHandling { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_PAYMENTTYPE")]
       public string OidPaymentType { get; set; }


       #endregion Public Properties
   }
}
