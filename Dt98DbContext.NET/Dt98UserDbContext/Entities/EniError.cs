using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Oid))]
   [Table("ENI_ERROR")]
   public class EniError
   {
      #region Public Constructors

       public EniError()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("Service")]
       public string Service { get; set; }

       [Column("MessageId")]
       public string MessageId { get; set; }

       [Column("MessageType")]
       public string MessageType { get; set; }

       [Column("MessageNumber")]
       public int MessageNumber { get; set; }

       [Column("MessageText")]
       public string MessageText { get; set; }

       [Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }

       [Column("DateTime")]
       public DateTime DateTime { get; set; }


       #endregion Public Properties
   }
}
