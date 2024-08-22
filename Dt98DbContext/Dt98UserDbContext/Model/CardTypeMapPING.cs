//==================================================================================================
//  FILE        :   _sctCARDTYPEMAPPING.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sctCARDTYPEMAPPING")]
   public class CardTypeMapPING
   {
      #region Public Constructors

       public CardTypeMapPING()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TYPE_BOF")]
       public string TypeBof { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("BOF_NAME")]
       public string BofName { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("BOF_ID")]
       public string BofId { get; set; }


       #endregion Public Properties
   }
}
