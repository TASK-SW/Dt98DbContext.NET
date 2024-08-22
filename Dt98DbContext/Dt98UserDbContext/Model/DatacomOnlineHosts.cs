//==================================================================================================
//  FILE        :   DatacomOnlineHosts.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("DatacomOnlineHosts")]
   public class DatacomOnlineHosts
   {
      #region Public Constructors

       public DatacomOnlineHosts()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("HostId")]
       public int HostId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("RecordState")]
       public int RecordState { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ApplicationId")]
       public string ApplicationId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("HostAddressIsdnB")]
       public string HostAddressIsdnB { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("HostAddressIP")]
       public string HostAddressIP { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("MessageTimeout")]
       public int MessageTimeout { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("RetryCountAuthorization")]
       public int RetryCountAuthorization { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("RetryCountCancellation")]
       public int RetryCountCancellation { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("MACKeyId")]
       public int MacKeyId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("MACKey")]
       public string MacKey { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ENCKeyId")]
       public int ENCKeyId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ENCKey")]
       public string ENCKey { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OlisVersion")]
       public int OlisVersion { get; set; }


       #endregion Public Properties
   }
}
