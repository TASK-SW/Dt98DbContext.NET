using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(ProductId), nameof(FuelpointId), nameof(NozzleId), nameof(TsBegin), nameof(TankId))]
   [Table("VMARECORDSTANK")]
   public class VmaRecordsTank
   {
      #region Public Constructors

       public VmaRecordsTank()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("ProductId")]
       public int ProductId { get; set; }

        [Key]
        [Column("FuelpointId")]
       public int FuelpointId { get; set; }

        [Key]
        [Column("NozzleId")]
       public int NozzleId { get; set; }

        [Key]
        [Column("TSBegin")]
       public DateTime TsBegin { get; set; }

        [Key]
        [Column("TankId")]
       public int TankId { get; set; }

       [Column("TankMeter")]
       public decimal TankMeter { get; set; }


       #endregion Public Properties
   }
}
