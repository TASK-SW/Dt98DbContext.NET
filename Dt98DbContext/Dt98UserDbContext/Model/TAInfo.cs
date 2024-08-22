//==================================================================================================
//  FILE        :   TA_INFO.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("TA_INFO")]
   public class TAInfo
   {
      #region Public Constructors

       public TAInfo()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public int Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("APP_ID")]
       public string APPId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("REC_ID")]
       public string RECId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_TIMESTAMP")]
       public DateTime DTTimeStamp { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FILENAME")]
       public string FileName { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("STATUS")]
       public int Status { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CONTENT")]
       public string Content { get; set; }


       #endregion Public Properties
   }
}
