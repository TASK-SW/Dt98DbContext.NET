//==================================================================================================
//  FILE        :   _sptCARDFILES.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     19.07.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptCARDFILES")]
   public class sptCardFiles
   {
      #region Public Constructors

       public sptCardFiles()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Key]
       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_BLACKLIST")]
       public string OidBlackList { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_GREYLIST")]
       public string OidGreyList { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_REDLIST")]
       public string OidRedList { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_CARDDLYTOTAL")]
       public string OidCardDLYTotal { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_CARDTRXCOUNT")]
       public string OidCardTRXCount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_TRXFILE")]
       public string OidTRXFile { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_HOST")]
       public string OidHost { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_CARDDATACOM")]
       public string OidCardDataCom { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_FOREIGNTRX")]
       public string OidForeignTRX { get; set; }


       #endregion Public Properties
   }
}
