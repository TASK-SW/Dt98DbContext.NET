//==================================================================================================
//  FILE        :   ENI_ERROR.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("ENI_ERROR")]
   public class ENIError
   {
      #region Public Constructors

       public ENIError()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Service")]
       public string Service { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("MessageId")]
       public string MessageId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("MessageType")]
       public string MessageType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("MessageNumber")]
       public int MessageNumber { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("MessageText")]
       public string MessageText { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DateTime")]
       public DateTime DateTime { get; set; }


       #endregion Public Properties
   }
}
