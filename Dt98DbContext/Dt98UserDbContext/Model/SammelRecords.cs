using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("SAMMELRECORDS")]
   public class SammelRecords
   {
      #region Public Constructors

       public SammelRecords()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("DateTime")]
       public DateTime DateTime { get; set; }

       [Column("Data")]
       public string Data { get; set; }

       [Column("HostDeliveryState")]
       public int HostDeliveryState { get; set; }


       #endregion Public Properties
   }
}
