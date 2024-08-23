using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("VMA_Current")]
   public class VmaCurrent
   {
      #region Public Constructors

       public VmaCurrent()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("ProductId")]
       public int ProductId { get; set; }

       [Key, Column(Order = 1)]
       //[Column("FuelPointId")]
       public int FuelPointId { get; set; }

       [Key, Column(Order = 2)]
       //[Column("NozzleId")]
       public int NozzleId { get; set; }

       [Key, Column(Order = 3)]
       //[Column("TankId")]
       public int TankId { get; set; }

       [Column("Volume")]
       public decimal Volume { get; set; }

       [Column("Amount")]
       public decimal Amount { get; set; }


       #endregion Public Properties
   }
}
