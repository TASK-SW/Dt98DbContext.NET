using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(ProductId), nameof(FuelpointId), nameof(NozzleId), nameof(TsBegin), nameof(TankId))]
   [Table("VMARECORDSTANK")]
   public class VmaRecordsTank
   {
      #region Public Constructors

       public VmaRecordsTank()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("ProductId")]
       public int ProductId { get; set; }

       [Column("FuelpointId")]
       public int FuelpointId { get; set; }

       [Column("NozzleId")]
       public int NozzleId { get; set; }

       [Column("TSBegin")]
       public DateTime TsBegin { get; set; }

       [Column("TankId")]
       public int TankId { get; set; }

       [Column("TankMeter")]
       public decimal TankMeter { get; set; }


       #endregion Public Properties
   }
}
