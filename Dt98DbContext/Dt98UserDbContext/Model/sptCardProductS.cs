//==================================================================================================
//  FILE        :   _sptCARDPRODUCTS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     19.07.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptCARDPRODUCTS")]
   public class sptCardProductS
   {
      #region Public Constructors

       public sptCardProductS()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Key]
       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_CARDTYPE")]
       public string OidCardType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("SERVICECODE")]
       public int ServiceCode { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("SERVICEVALUE")]
       public int ServiceValue { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PRODUCTS")]
       public string ProductS { get; set; }


       #endregion Public Properties
   }
}
