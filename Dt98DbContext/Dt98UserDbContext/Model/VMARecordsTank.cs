using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("VMARECORDSTANK")]
   public class VmaRecordsTank
   {
      #region Public Constructors

       public VmaRecordsTank()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("ProductId")]
       public int ProductId { get; set; }

       [Key, Column(Order = 1)]
       //[Column("FuelpointId")]
       public int FuelpointId { get; set; }

       [Key, Column(Order = 2)]
       //[Column("NozzleId")]
       public int NozzleId { get; set; }

       [Key, Column(Order = 3)]
       //[Column("TSBegin")]
       public DateTime TsBegin { get; set; }

       [Key, Column(Order = 4)]
       //[Column("TankId")]
       public int TankId { get; set; }

       [Column("TankMeter")]
       public decimal TankMeter { get; set; }


       #endregion Public Properties
   }
}
