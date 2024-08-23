using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("ENI_ERROR")]
   public class EniError
   {
      #region Public Constructors

       public EniError()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
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
