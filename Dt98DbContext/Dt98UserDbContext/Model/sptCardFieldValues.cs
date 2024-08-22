//==================================================================================================
//  FILE        :   _sptCARDFIELDVALUES.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     19.07.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptCARDFIELDVALUES")]
   public class sptCardFieldValues
   {
      #region Public Constructors

       public sptCardFieldValues()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Key]
       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_FIELD")]
       public string OidField { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VALUE")]
       public string Value { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CLSID")]
       public string CLSId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("IID")]
       public string IId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("INTERNALCODE")]
       public string InternalCode { get; set; }


       #endregion Public Properties
   }
}
