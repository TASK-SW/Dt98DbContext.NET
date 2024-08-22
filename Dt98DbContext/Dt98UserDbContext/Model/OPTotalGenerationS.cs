//==================================================================================================
//  FILE        :   OPTOTALGENERATIONS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("OPTOTALGENERATIONS")]
   public class OPTotalGenerationS
   {
      #region Public Constructors

       public OPTotalGenerationS()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_HOST")]
       public string OidHost { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("GENERATION")]
       public int Generation { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CYCLESTART")]
       public DateTime CycleStart { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CYCLEEND")]
       public DateTime CycleEnd { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CREATIONSTART")]
       public DateTime CreationStart { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CREATIONEND")]
       public DateTime CreationEnd { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DELIVERYDATE")]
       public DateTime DeliveryDate { get; set; }


       #endregion Public Properties
   }
}
