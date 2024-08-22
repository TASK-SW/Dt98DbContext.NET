//==================================================================================================
//  FILE        :   _sptGREYLISTS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     19.07.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptGREYLISTS")]
   public class sptGreyListS
   {
      #region Public Constructors

       public sptGreyListS()
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

       [System.ComponentModel.DataAnnotations.Schema.Column("GENNO")]
       public string GenNO { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("UPGENNO")]
       public string UPGenNO { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VERSION")]
       public string Version { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VALIDITY")]
       public int Validity { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DOWNLOADDATE")]
       public DateTime DownloadDate { get; set; }


       #endregion Public Properties
   }
}
