using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(ProductId), nameof(FuelPointId), nameof(NozzleId), nameof(TankId))]
   [Table("VMA_Current")]
   public class VmaCurrent
   {
      #region Public Constructors

       public VmaCurrent()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("ProductId")]
       public int ProductId { get; set; }

       [Column("FuelPointId")]
       public int FuelPointId { get; set; }

       [Column("NozzleId")]
       public int NozzleId { get; set; }

       [Column("TankId")]
       public int TankId { get; set; }

       [Column("Volume")]
       public decimal Volume { get; set; }

       [Column("Amount")]
       public decimal Amount { get; set; }


       #endregion Public Properties
   }
}
