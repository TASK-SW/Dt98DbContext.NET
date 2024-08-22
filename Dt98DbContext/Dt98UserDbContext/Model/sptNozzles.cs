//==================================================================================================
//  FILE        :   _sptNOZZLES.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     19.07.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptNOZZLES")]
   public class sptNozzles
   {
      #region Public Constructors

       public sptNozzles()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Key]
       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_TYPE")]
       public string OidType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_FUELINGPOINT")]
       public string OidFuelINGPoint { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_TANK")]
       public string OidTank { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
       public int Id { get; set; }


       #endregion Public Properties
   }
}
