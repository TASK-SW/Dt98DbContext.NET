//==================================================================================================
//  FILE        :   TRXFILES.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("TRXFILES")]
   public class TRXFiles
   {
      #region Public Constructors

       public TRXFiles()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_SEQUENCE")]
       public int DTSequence { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_RESETDATE")]
       public DateTime DTRESetDate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_ACTNUM")]
       public int Dtactnum { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_PASNUM")]
       public int Dtpasnum { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_VERSION")]
       public int DTVersion { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_LASTTRXDATE")]
       public DateTime DTLastTRXDate { get; set; }


       #endregion Public Properties
   }
}
