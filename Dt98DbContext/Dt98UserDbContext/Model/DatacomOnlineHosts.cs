using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("DatacomOnlineHosts")]
   public class DatacomOnlineHosts
   {
      #region Public Constructors

       public DatacomOnlineHosts()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("HostId")]
       public int HostId { get; set; }

       [Key, Column(Order = 1)]
       //[Column("RecordState")]
       public int RecordState { get; set; }

       [Key, Column(Order = 2)]
       //[Column("ApplicationId")]
       public string ApplicationId { get; set; }

       [Column("HostAddressIsdnB")]
       public string HostAddressIsdnB { get; set; }

       [Column("HostAddressIP")]
       public string HostAddressIP { get; set; }

       [Column("MessageTimeout")]
       public int MessageTimeout { get; set; }

       [Column("RetryCountAuthorization")]
       public int RetryCountAuthorization { get; set; }

       [Column("RetryCountCancellation")]
       public int RetryCountCancellation { get; set; }

       [Column("MACKeyId")]
       public int MacKeyId { get; set; }

       [Column("MACKey")]
       public string MacKey { get; set; }

       [Column("ENCKeyId")]
       public int EncKeyId { get; set; }

       [Column("ENCKey")]
       public string EncKey { get; set; }

       [Column("OlisVersion")]
       public int OlisVersion { get; set; }


       #endregion Public Properties
   }
}
