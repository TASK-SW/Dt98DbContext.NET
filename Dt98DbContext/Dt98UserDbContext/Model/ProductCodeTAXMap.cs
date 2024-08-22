//==================================================================================================
//  FILE        :   _sptPRODUCTCODETAXMAP.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptPRODUCTCODETAXMAP")]
   public class ProductCodeTAXMap
   {
      #region Public Constructors

       public ProductCodeTAXMap()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
       public int Id { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("EXTCODE")]
       public int EXTCode { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VAT_OID")]
       public string VATOid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PRODUCTCODENAME")]
       public string ProductCodeName { get; set; }


       #endregion Public Properties
   }
}
