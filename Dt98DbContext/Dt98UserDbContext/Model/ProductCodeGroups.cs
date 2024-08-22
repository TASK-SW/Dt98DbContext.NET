//==================================================================================================
//  FILE        :   _sptPRODUCTCODEGROUPS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptPRODUCTCODEGROUPS")]
   public class ProductCodeGroups
   {
      #region Public Constructors

       public ProductCodeGroups()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
       public int Id { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DESCRIPTION")]
       public string Description { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FIXED_VAT")]
       public int FixedVAT { get; set; }


       #endregion Public Properties
   }
}
