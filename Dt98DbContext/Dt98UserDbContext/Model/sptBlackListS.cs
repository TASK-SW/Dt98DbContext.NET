//==================================================================================================
//  FILE        :   _sptBLACKLISTS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     19.07.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptBLACKLISTS")]
   public class sptBlackListS
   {
      #region Public Constructors

       public sptBlackListS()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Key]
       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_TYPE")]
       public string OidType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
       public int Id { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VERSION")]
       public string Version { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VALIDITY")]
       public int Validity { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DOWNLOADDATE")]
       public DateTime DownloadDate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("GENNO")]
       public string GenNO { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("UPGENNO")]
       public string UPGenNO { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("GROUPDOWNLOADDATE")]
       public DateTime GroupDownloadDate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DATACOM_ID")]
       public int DataComId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PAN_LENGTH")]
       public int PANLength { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("STRIP_LENGTH")]
       public int StripLength { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("EXPIRATION_DAYS")]
       public int ExpirationDayS { get; set; }


       #endregion Public Properties
   }
}
