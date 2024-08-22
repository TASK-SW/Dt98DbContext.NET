//==================================================================================================
//  FILE        :   TRXGENERATIONS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("TRXGENERATIONS")]
   public class TRXGenerationS
   {
      #region Public Constructors

       public TRXGenerationS()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_TRX")]
       public string OidTRX { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("GENERATION")]
       public int Generation { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("STARTDATE")]
       public DateTime StartDate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ENDDATE")]
       public DateTime EndDate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DELIVERYDATE")]
       public DateTime DeliveryDate { get; set; }


       #endregion Public Properties
   }
}
